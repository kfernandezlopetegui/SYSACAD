using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using Entidades;

namespace LecturaEscritura
{
    public class CRUD
    {
        public static List<T> ReadStreamJSON<T>(string file)
        {
            var path = Combine(file);

            var lista = new List<T>();

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    var json = reader.ReadToEnd();

                    var listaAux = JsonSerializer.Deserialize<List<T>>(json);

                    if (listaAux != null)
                    {
                        lista = listaAux;
                    }
                }
            }

            return lista;
        }
        public static void WriteStreamJSON<T>(string file, List<T> usuario)
        {


            using (var writer = new StreamWriter(Combine(file)))
            {
                var options = new JsonSerializerOptions();
                options.WriteIndented = true;

                var json = JsonSerializer.Serialize(usuario, typeof(List<T>), options);

                writer.Write(json);
            }
        }

        private static string Combine(string file)
        {
            Environment.SpecialFolder escritorio = Environment.SpecialFolder.DesktopDirectory;

            var desktop = Environment.GetFolderPath(escritorio);
            var path = Path.Combine(desktop,  file);

            return path;
        }

        public static void EscribirJsonTipo<T>(string file, List<T> usuarios)

        {
            string path = Combine(file);

            using (var writer = new StreamWriter(path))
            {
                var options = new JsonSerializerOptions();
                options.WriteIndented = true;

                var json = JsonSerializer.Serialize(usuarios, typeof(List<T>), options);

                writer.Write(json);
            }

        }


        public static void WriteNumeroLegajoJSON(string file, NumeroLegajo numeroLegajo)
        {
            using (var writer = new StreamWriter(Combine(file)))
            {
                var options = new JsonSerializerOptions();
                options.WriteIndented = true;

                var json = JsonSerializer.Serialize(numeroLegajo, typeof(NumeroLegajo), options);

                writer.Write(json);
            }
        }

        public static NumeroLegajo ReadNumeroLegajoJSON(string file)
        {
            string path = Combine(file);

            if (File.Exists(path))
            {
                try
                {
                    using (var reader = new StreamReader(path))
                    {
                        var json = reader.ReadToEnd();
                        return JsonSerializer.Deserialize<NumeroLegajo>(json);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer el archivo JSON: " + ex.Message);
                }
            }

           
            return new NumeroLegajo(-1); 
        }

        public static bool VerificarSiExisteArchivo(string file)
        {
            string path = Combine(file);

            if (File.Exists(path))
            {
                return true;
            }
            return false;
        }
    }
}