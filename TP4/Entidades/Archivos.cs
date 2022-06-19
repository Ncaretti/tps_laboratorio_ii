using System;
using System.IO;

namespace Entidades
{
    public class Archivos
    {
        static string path;

        /// <summary>
        /// Constructor que busca y guarda la ruta donde guardaran los tickets
        /// </summary>
        static Archivos()
        {
            path = AppDomain.CurrentDomain.BaseDirectory;
            path += @"\Tickets\";
        }

        /// <summary>
        /// Metodo que genera tickets con los datos del cliente y del arma
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nombreArma"></param>
        /// <param name="nombreSkin"></param>
        /// <param name="precio"></param>
        public static void Escribir(string nombre, string apellido, int dni, string nombreArma, string nombreSkin, double precio)
        {
            string nombreArchivo = path + "Ticket " + " " + nombre + " " + apellido + " " + dni + " " + DateTime.Now.ToString("HH_mm_ss") + ".txt";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    sw.WriteLine("|------------------------------------DELICKS STORE-------------------------------------|");
                    sw.WriteLine("|                                                                                      |");
                    sw.WriteLine($"|Comprobante de compra del cliente: {nombre} {apellido} {dni}  {DateTime.Now}|");
                    sw.WriteLine("|                                                                                      |");
                    sw.WriteLine("|--------------------------------------ARTICULOS---------------------------------------|");
                    sw.WriteLine($"|{nombreArma} | {nombreSkin}                                                          |");
                    sw.WriteLine("|--------------------------------------------------------------------------------------|");
                    sw.WriteLine($"|TOTAL = {precio}                                                                     |");
                    sw.WriteLine("|-------------------------------GRACIAS POR SU COMPRA----------------------------------|");
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }
    }
}
