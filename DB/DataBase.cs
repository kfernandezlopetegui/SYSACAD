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
        private static string cadenaConexion = @"Server=.;Database=Prueba;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public DataBase()
        {
            
        }

        public static string CreateTable<T>()
        {
            
            
            string createTableQuery = BuildCreateTableQuery<T>();
            conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            using (SqlCommand command = new SqlCommand(createTableQuery, conexion))
            {
                command.ExecuteNonQuery();
            }

            return createTableQuery;

           
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
    }
}