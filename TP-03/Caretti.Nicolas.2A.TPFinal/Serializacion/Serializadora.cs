using System;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace Serializacion
{
    public static class ClaseSerializadora<T>
    {
        static string path;

        /// <summary>
        /// Constructor que busca la ruta principal donde estaran los archivos
        /// </summary>
        static ClaseSerializadora()
        {
            path = AppDomain.CurrentDomain.BaseDirectory;
            path += @"\Listas\";
        }

        /// <summary>
        /// Metodo que escribe los datos que recibe por parametro en un archivo XML con la ruta ya obtenida mas el
        /// nombre que le indicamos tambien por parametro
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="nombreFile"></param>
        public static void Escribir(T datos, string nombreFile)
        {
            string nombreArchivo = path + "SerializacionArmasXML_" + nombreFile + ".xml";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, datos);
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }

        /// <summary>
        /// Metodo que escribe la lista de Ventas que recibe por parametro en un archivo XML con la ruta ya obtenida mas el
        /// nombre que le indicamos tambien por parametro
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="nombreFile"></param>
        public static void EscribirVentas(T datos, string nombreFile)
        {
            string nombreArchivo = path + "SerializacionVentasXML_" + nombreFile + ".xml";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, datos);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }

        /// <summary>
        /// Metodo que lee el archivo XML que recibe por parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static T Leer(string nombre)
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            T datos = default;
            try
            {
                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombre))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        using (StreamReader sr = new StreamReader(archivo))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            datos = (T)xmlSerializer.Deserialize(sr);
                        }
                    }
                }

                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }

        /// <summary>
        /// Metodo que escribe la lista que recibe por parametro en un archivo JSON con la ruta ya obtenida mas el
        /// nombre que le indicamos tambien por parametro
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="nombreFile"></param>
        public static void EscribirJson(T datos, string nombre)
        {
            string nombreArchivo = path + "SerializacionClientesJSON" + nombre + ".json";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }


                File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(datos));

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }

        /// <summary>
        /// Metodo que lee el archivo JSON que recibe por parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static T LeerJson(string nombre)
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            T datosRecuperados = default;
            try
            {

                if (Directory.Exists(path))
                {
                    // recupera los nombres de los archivos que hay en esa carpeta incluida la ruta
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombre))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        datosRecuperados = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
                    }
                }

                return datosRecuperados;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }
    }
}
