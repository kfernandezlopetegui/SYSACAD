using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class CRUDB
    {
        
        private static string cadenaConexion = @"Server=.;Database=SysacadPrueba;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public static async Task<string> CreateTableAsync<T>()
        {
            string tableName = typeof(T).Name;

            // Verifica si la tabla ya existe
            if (DataBase.TablaExiste(tableName))
            {
                return $"La tabla '{tableName}' ya existe en la base de datos.";
            }

            string createTableQuery = DataBase.BuildCreateTableQuery<T>();

            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                    {
                        await command.ExecuteNonQueryAsync();
                    }
                }

                return $"Tabla '{tableName}' creada exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Error al crear la tabla '{tableName}': {ex.Message}";
            }
        }

        public static List<T> ObtenerTodos<T>(string nombreTabla)
        {
            List<T> listaObjetos = new List<T>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                Type tipo = typeof(T);
                PropertyInfo[] propiedades = tipo.GetProperties();

                string consultaSql = $"SELECT * FROM {nombreTabla}";

                using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                {
                    try
                    {
                        conexion.Open();

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                T objeto = Activator.CreateInstance<T>();

                                foreach (var propiedad in propiedades)
                                {
                                    int ordinal = reader.GetOrdinal(propiedad.Name);

                                    if (propiedad.PropertyType == typeof(int))
                                    {
                                        propiedad.SetValue(objeto, reader.GetInt32(ordinal));
                                    }
                                    else if (propiedad.PropertyType == typeof(string))
                                    {
                                        propiedad.SetValue(objeto, reader.GetString(ordinal));
                                    }
                                    else if (propiedad.PropertyType == typeof(bool))
                                    {
                                        propiedad.SetValue(objeto, reader.GetBoolean(ordinal));
                                    }
                                    else if (propiedad.PropertyType == typeof(double))
                                    {
                                        propiedad.SetValue(objeto, reader.GetDouble(ordinal));
                                    }
                                    // ...
                                }

                                listaObjetos.Add(objeto);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción según tus necesidades
                        Console.WriteLine($"Error al obtener objetos: {ex.Message}");
                    }
                }
            }

            return listaObjetos;
        }

        public static bool EsIdentificadorUnico<T>(string nombreTabla, string columnaId, object valorId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    string query = $"SELECT COUNT(*) FROM {nombreTabla} WHERE {columnaId} = @{columnaId}";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Añade el parámetro de ID a la consulta
                        SqlParameter idParameter = new SqlParameter($"@{columnaId}", valorId);
                        command.Parameters.Add(idParameter);

                        int count = (int)command.ExecuteScalar();

                        // Si el recuento es cero, significa que el identificador es único
                        return count == 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades (por ejemplo, registrarla, lanzarla nuevamente, etc.)
                Console.WriteLine($"Error al verificar la unicidad del identificador: {ex.Message}");
                return false;
            }
        }

        public static async Task<string> InsertarRegistroAsync<T>(T objeto)
        {
            string consulta = DataBase.ConstruirQueryInsert(objeto);

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    PropertyInfo[] propiedades = typeof(T).GetProperties();

                    foreach (var propiedad in propiedades)
                    {
                        string nombreColumna = propiedad.Name;
                        object valor = propiedad.GetValue(objeto);

                        if (valor != null)  // Ignorar propiedades nulas
                        {
                            command.Parameters.AddWithValue($"@{nombreColumna}", valor);
                        }
                        
                    }

                    try
                    {
                        int filasAfectadas = await command.ExecuteNonQueryAsync();

                        if (filasAfectadas > 0)
                        {
                            return $"{typeof(T).Name} agregado correctamente a la tabla.";
                        }
                        else
                        {
                            return $"No se pudo agregar el {typeof(T).Name} a la tabla.";
                        }
                    }
                    catch (SqlException ex)
                    {
                        return $"Error al insertar el {typeof(T).Name}: {ex.Message}";
                    }
                }
            }
        }

        public static async Task<string> EliminarPorCondicionAsync<T>(string nombreTabla, string columna, object valor)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consultaSql = $"DELETE FROM {nombreTabla} WHERE {columna} = @Valor";

                using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                {
                    comando.Parameters.AddWithValue("@Valor", valor);

                    try
                    {
                        await conexion.OpenAsync();
                        int filasAfectadas = await comando.ExecuteNonQueryAsync();

                        if (filasAfectadas > 0)
                        {
                            return $"Eliminación exitosa. Filas afectadas: {filasAfectadas}";
                        }
                        else
                        {
                            return "No se encontraron filas para eliminar.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return $"Error al eliminar filas: {ex.Message}";
                    }
                }
            }
        }

        public static async Task<string> ActualizarPorIdentificadorAsync<T>(string nombreTabla, string columnaId, object valorId, T objetoActualizado)
        {
            try
            {
                await EliminarPorCondicionAsync<T>(nombreTabla, columnaId, valorId);
                await CRUDB.InsertarRegistroAsync<T>(objetoActualizado);

                return "Actualización exitosa.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar: {ex.Message}";
            }
        }

        public static async Task<T> ObtenerPorIdentificadorAsync<T>(string nombreTabla, string condicion, object parametros = null)
        {
            return await Task.Run(() =>
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string consultaSql = $"SELECT TOP 1 * FROM {nombreTabla} WHERE {condicion}";
                    using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                    {
                        conexion.Open();
                        if (parametros != null)
                        {
                            foreach (var propiedad in parametros.GetType().GetProperties())
                            {
                                comando.Parameters.AddWithValue($"@{propiedad.Name}", propiedad.GetValue(parametros));
                            }
                        }

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                T obj = Activator.CreateInstance<T>();

                                foreach (var propiedad in typeof(T).GetProperties())
                                {
                                    var valor = reader[propiedad.Name];
                                    if (valor != DBNull.Value)
                                    {
                                        propiedad.SetValue(obj, valor);
                                    }
                                }

                                return obj;
                            }
                        }
                    }

                    return default(T);
                }
            });
        }

        public static List<SolicitudListaEsperaDetallada> ObtenerTodosSolicitudesListaEsperaDetalladas()
        {
            List<SolicitudListaEsperaDetallada> listaSolicitudes = new List<SolicitudListaEsperaDetallada>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consultaSql = @"
                 SELECT LE.Id AS IdSolicitud, LE.FechaSolicitud,
                 A.Dni AS IdAlumno, A.Nombre AS NombreAlumno, A.Apellido, A.Legajo,
                 C.Codigo AS IdCurso, C.Nombre AS NombreCurso
                 FROM ListaEspera LE
                JOIN Alumno A ON LE.IdAlumno = A.Dni
                 JOIN Curso C ON LE.IdCurso = C.Codigo
                    ";

                using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                {
                    try
                    {
                        conexion.Open();

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SolicitudListaEsperaDetallada solicitud = new SolicitudListaEsperaDetallada
                                {
                                    IdSolicitud = reader.GetInt32(reader.GetOrdinal("IdSolicitud")),
                                    FechaSolicitud = reader.GetDateTime(reader.GetOrdinal("FechaSolicitud")),
                                    IdAlumno = reader.GetInt32(reader.GetOrdinal("IdAlumno")),
                                    NombreAlumno = reader.GetString(reader.GetOrdinal("NombreAlumno")),
                                    ApellidoAlumno = reader.GetString(reader.GetOrdinal("Apellido")),
                                    LegajoAlumno = reader.GetInt32(reader.GetOrdinal("Legajo")),
                                    IdCurso = reader.GetString(reader.GetOrdinal("IdCurso")),
                                    NombreCurso = reader.GetString(reader.GetOrdinal("NombreCurso")),


                                };

                                listaSolicitudes.Add(solicitud);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción según tus necesidades
                        Console.WriteLine($"Error al obtener solicitudes: {ex.Message}");
                    }
                }
            }

            return listaSolicitudes;
        }

        public static List<SolicitudListaEsperaDetallada> ObtenerSolicitudesPorIdCurso(string idCurso)
        {
            List<SolicitudListaEsperaDetallada> listaSolicitudes = new List<SolicitudListaEsperaDetallada>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consultaSql = @"
            SELECT 
                LE.Id AS IdSolicitud, 
                LE.FechaSolicitud,
                C.Codigo AS IdCurso,
                C.Nombre AS NombreCurso,
                A.Dni AS IdAlumno,
                A.Nombre AS NombreAlumno,
                A.Apellido,
                A.Legajo
            FROM ListaEspera LE
            JOIN Alumno A ON LE.IdAlumno = A.Dni
            JOIN Curso C ON LE.IdCurso = C.Codigo
            WHERE C.Codigo = @IdCurso
            ORDER BY LE.FechaSolicitud";

                using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.Parameters.AddWithValue("@IdCurso", idCurso);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SolicitudListaEsperaDetallada solicitud = new SolicitudListaEsperaDetallada
                                {
                                    IdSolicitud = reader.GetInt32(reader.GetOrdinal("IdSolicitud")),
                                    FechaSolicitud = reader.GetDateTime(reader.GetOrdinal("FechaSolicitud")),
                                    IdCurso = reader.GetString(reader.GetOrdinal("IdCurso")),
                                    NombreCurso = reader.GetString(reader.GetOrdinal("NombreCurso")),
                                    IdAlumno = reader.GetInt32(reader.GetOrdinal("IdAlumno")),
                                    NombreAlumno = reader.GetString(reader.GetOrdinal("NombreAlumno")),
                                    ApellidoAlumno = reader.GetString(reader.GetOrdinal("Apellido")),
                                    LegajoAlumno = reader.GetInt32(reader.GetOrdinal("Legajo"))
                                };

                                listaSolicitudes.Add(solicitud);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción según tus necesidades
                        Console.WriteLine($"Error al obtener solicitudes por ID de curso: {ex.Message}");
                    }
                }
            }

            return listaSolicitudes;
        }

        public static List<Curso> ObtenerCursosConListaEspera()
        {
            List<Curso> cursosConListaEspera = new List<Curso>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consultaSql = @"
            SELECT DISTINCT C.*
            FROM Curso C
            INNER JOIN ListaEspera LE ON C.Codigo = LE.IdCurso";

                using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                {
                    try
                    {
                        conexion.Open();

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Curso curso = new Curso
                                {
                                    Codigo = reader.GetString(reader.GetOrdinal("Codigo")),
                                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                    Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
                                    CupoMaximo = reader.GetInt32(reader.GetOrdinal("CupoMaximo")),
                                    CupoActual = reader.GetInt32(reader.GetOrdinal("CupoActual")),
                                    Carrera = reader.GetString(reader.GetOrdinal("Carrera")),
                                    IdRequisitos = reader.GetInt32(reader.GetOrdinal("IdRequisitos")),
                                    // Agrega otras propiedades según tu modelo de datos
                                };

                                cursosConListaEspera.Add(curso);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción según tus necesidades
                        Console.WriteLine($"Error al obtener cursos con lista de espera: {ex.Message}");
                    }
                }
            }

            return cursosConListaEspera;
        }

        public static List<ProfesorConCurso> ObtenerDatosProfesores()
        {
            List<ProfesorConCurso> listaProfesores = new List<ProfesorConCurso>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consultaSql = @"
                      SELECT 
                      P.Dni,
                      P.Nombre,
                      P.Apellido,
                      P.Direccion,
                      P.NumeroTelefono,
                      P.AreasEspecializacion,
                      P.Legajo,
                      P.Email,
                      STRING_AGG(C.Nombre, ', ') AS CursosAsignados
                      FROM Profesor P
                      JOIN CursosAsignados CA ON P.Dni = CA.IdProfesor
                      JOIN Curso C ON CA.IdCurso = C.Codigo
                      GROUP BY 
                      P.Dni,
                      P.Nombre,
                      P.Apellido,
                      P.Direccion,
                      P.NumeroTelefono,
                      P.AreasEspecializacion,
                      P.Legajo,
                      P.Email;
                            ";

                using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                {
                    try
                    {
                        conexion.Open();

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ProfesorConCurso profesor = new ProfesorConCurso
                                {
                                    IdProfesor = reader.GetInt32(reader.GetOrdinal("Dni")),
                                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                    Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                                    Direccion = reader.GetString(reader.GetOrdinal("Direccion")),
                                    NumeroTelefono = reader.GetString(reader.GetOrdinal("NumeroTelefono")),
                                    AreasEspecializacion = reader.GetString(reader.GetOrdinal("AreasEspecializacion")),
                                    CursosAsignados = reader.GetString(reader.GetOrdinal("CursosAsignados")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Legajo = reader.GetInt32(reader.GetOrdinal("Legajo")),
                                };

                                listaProfesores.Add(profesor);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción según tus necesidades
                        Console.WriteLine($"Error al obtener datos de profesores: {ex.Message}");
                    }
                }
            }

            return listaProfesores;
        }

    }

}

