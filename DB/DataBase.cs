using Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;



namespace DB
{
    public class DataBase
    {
        private static SqlConnection? conexion;
        private static string cadenaConexion = @"Server=.;Database=SysacadPrueba;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public DataBase()
        {
            
        }

        
        public static string CreateTable<T>()
        {
            string tableName = typeof(T).Name;

            // Verifica si la tabla ya existe
            if (TablaExiste(tableName))
            {
                return $"La tabla '{tableName}' ya existe en la base de datos.";
            }

            string createTableQuery = BuildCreateTableQuery<T>();

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                using (SqlCommand command = new SqlCommand(createTableQuery, conexion))
                {
                    command.ExecuteNonQuery();
                }

                return $"Tabla '{tableName}' creada exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Error al crear la tabla '{tableName}': {ex.Message}";
            }
            finally
            {
                conexion.Close();
            }
        }

        private static string ObtenerSqlDbType(Type type)
        {
            if (type == typeof(int))
            {
                return "INT";
            }
            else if (type == typeof(long))
            {
                return "BIGINT";
            }
            else if (type == typeof(string))
            {
                return "NVARCHAR(MAX)";
            }
            else if (type == typeof(double))
            {
                return "FLOAT";
            }
            else if (type == typeof(bool))
            {
                return "BIT";
            }
            else if (type == typeof(DateTime))
            {
                return "DATETIME";
            }
            // Agrega más tipos de datos según sea necesario
            // ...
            else
            {
                throw new NotSupportedException($"Tipo de datos {type} no compatible con SQL Server.");
            }
        }

        public static string BuildCreateTableQuery<T>()
        {
            Type tipo = typeof(T);
            var propiedades = tipo.GetProperties();

            StringBuilder scriptCreacionTabla = new StringBuilder($"CREATE TABLE {tipo.Name} (");

            foreach (var propiedad in propiedades)
            {
                string nombreColumna = propiedad.Name;
                string tipoDato = ObtenerSqlDbType(propiedad.PropertyType);

                if (propiedad.IsDefined(typeof(PrimaryKeyAtributo), false))
                {
                    scriptCreacionTabla.Append($"{nombreColumna} {tipoDato} PRIMARY KEY, ");
                }
                else if (propiedad.IsDefined(typeof(ForeignKeyAtributo), false))
                {
                    var atributoForeignKey = (ForeignKeyAtributo)propiedad.GetCustomAttribute(typeof(ForeignKeyAtributo), false);
                    string referenciaTabla = atributoForeignKey.ReferenceType.Name;
                    scriptCreacionTabla.Append($"{nombreColumna} {tipoDato} REFERENCES {referenciaTabla}, ");
                }
                else
                {
                    scriptCreacionTabla.Append($"{nombreColumna} {tipoDato}, ");
                }
            }

            // Elimina la última coma y el espacio
            if (scriptCreacionTabla.Length > 2)
            {
                scriptCreacionTabla.Length -= 2;
            }

            scriptCreacionTabla.Append(")");

            return scriptCreacionTabla.ToString();
        }


        public static int ObtenerUltimoLegajo()
        {
            int ultimoLegajo = 0;

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string query = "SELECT TOP 1 Legajo FROM Alumno ORDER BY Legajo DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        ultimoLegajo = Convert.ToInt32(result);
                    }
                }
            }

            return ultimoLegajo;
        }

        public static bool VerificarTablaVacia(string nombreTabla)
        {
            bool tablaVacia = true;

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM {nombreTabla}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int cantidadFilas = Convert.ToInt32(command.ExecuteScalar());
                    if (cantidadFilas > 0)
                    {
                        tablaVacia = false;
                    }
                }
            }

            return tablaVacia;
        }

        public static bool VerificarBaseDeDatosVacia()
        {
            bool baseDeDatosVacia = true;

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                // Consulta para contar la cantidad de tablas en la base de datos
                string query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int cantidadTablas = Convert.ToInt32(command.ExecuteScalar());
                    if (cantidadTablas > 0)
                    {
                        baseDeDatosVacia = false;
                    }
                }
            }

            return baseDeDatosVacia;
        }

        public static string ConstruirQueryInsert<T>(T objeto)
        {
            Type tipo = typeof(T);
            PropertyInfo[] propiedades = tipo.GetProperties();

            StringBuilder query = new StringBuilder($"INSERT INTO {tipo.Name} (");
            StringBuilder values = new StringBuilder("VALUES (");

            foreach (var propiedad in propiedades)
            {
                string nombreColumna = propiedad.Name;
                object valor = propiedad.GetValue(objeto);

                if (valor != null)  // Ignorar propiedades nulas
                {
                    query.Append($"{nombreColumna}, ");
                    values.Append($"@{nombreColumna}, ");
                }
            }

            // Eliminar la última coma y el espacio de los strings de consulta
            query.Length -= 2;
            values.Length -= 2;

            query.Append(") ");
            values.Append(")");

            query.Append(values.ToString());

            return query.ToString();
        }

        
        public static bool TablaExiste(string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    string query = $"SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        return command.ExecuteScalar() != null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar la existencia de la tabla: {ex.Message}");
                return false; // En caso de error, asumimos que la tabla no existe
            }
        }

    }
}