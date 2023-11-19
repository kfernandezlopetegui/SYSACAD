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


    }

}

