using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadoDAO
    {
        private static string connectionString;
        private SqlConnection connection;
        private SqlCommand command;
        public event Action desactivarBorrado;

        /// <summary>
        /// Constructor estatico que establece el string de la conexion a la base de datos.
        /// </summary>
        static EmpleadoDAO()
        {
            EmpleadoDAO.connectionString = @"Server=.;Database=EmpleadosDB; Trusted_Connection=True;";
        }

        /// <summary>
        /// Constructor que inicializa un objeto de tipo SqlConnection
        /// </summary>
        public EmpleadoDAO()
        {
            connection = new SqlConnection(EmpleadoDAO.connectionString);
        }

        /// <summary>
        /// Metodo que comprueba la conexion a la base de datos.
        /// </summary>
        /// <returns></returns>
        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.connection.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }

        /// <summary>
        /// Metodo que guarda un nuevo empleado en la base de datos.
        /// </summary>
        /// <param name="empleado"></param>
        public void Guardar(Empleado empleado)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO Empleados (nombre, apellido, dni, puesto, sueldo) VALUES (@nombre, @apellido, @dni, @puesto, @sueldo)";

                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", empleado.Nombre);
                command.Parameters.AddWithValue("@apellido", empleado.Apellido);
                command.Parameters.AddWithValue("@dni", empleado.Dni);
                command.Parameters.AddWithValue("@puesto", empleado.Puesto);
                command.Parameters.AddWithValue("@sueldo", empleado.Sueldo);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Metodo que recorre la base de datos y retorna en una lista los datos
        /// </summary>
        /// <returns></returns>
        public List<Empleado> Leer()
        {
            List<Empleado> lista = new List<Empleado>();
            try
            {
                this.command = new SqlCommand();

                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "SELECT * FROM Empleados";
                this.command.Connection = this.connection;

                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int legajo = dataReader.GetInt32(0);
                    string nombre = dataReader.GetString(1);
                    string apellido = dataReader.GetString(2);
                    int dni = dataReader.GetInt32(3);
                    string puesto = dataReader.GetString(4);
                    float sueldo = float.Parse(dataReader[5].ToString());

                    Empleado empleado = new Empleado(legajo, nombre, apellido, dni, puesto, sueldo);

                    lista.Add(empleado);
                }

                dataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return lista;
        }

        /// <summary>
        /// Metodo que permite la modificacion de un objeto de tipo Empleado.
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="empleado"></param>
        public void Modificar(int legajo, Empleado empleado)
        {
            try
            {
                string query = "UPDATE Empleados SET nombre = @nombre, apellido = @apellido, dni = @dni, puesto = @puesto, sueldo = @sueldo WHERE legajo = @legajo";

                connection.Open();

                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@legajo", legajo);
                command.Parameters.AddWithValue("@nombre", empleado.Nombre);
                command.Parameters.AddWithValue("@apellido", empleado.Apellido);
                command.Parameters.AddWithValue("@dni", empleado.Dni);
                command.Parameters.AddWithValue("@puesto", empleado.Puesto);
                command.Parameters.AddWithValue("@sueldo", empleado.Sueldo);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Metodo que permite la eliminacion de un objeto de tipo Empleado.
        /// </summary>
        /// <param name="legajo"></param>
        public void Eliminar(int legajo)
        {
            try
            {
                string query = "DELETE FROM Empleados WHERE legajo = @legajo";

                connection.Open();

                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@legajo", legajo);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Metodo asincrono que implementa Hilos para simular una gran carga de datos desde SQL.
        /// </summary>
        /// <returns></returns>
        public static async Task<string> CargarEmpleadosAsync()
        {
            string informacion = await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "Registros cargados con exito!";
            });

            if (informacion.Length < 0)
            {
                informacion = "Error, no se encontraron registros.";
                throw new Exception("No se encontraron empleados en la base.");
            }

            return informacion;
        }

        /// <summary>
        /// Metodo que implementa Eventos y Delegados para enviar un mensaje y una activacion/desactivacion de un boton segun lo ocurrido en su invocacion.
        /// </summary>
        /// <param name="mensajeActivacion"></param>
        /// <param name="mensajeDesactivacion"></param>
        public void LimiteEmpleadosABorrar(Delegados.MensajeActivacion mensajeActivacion, Delegados.MensajeDesactivacion mensajeDesactivacion)
        {
            List<Empleado> lista = Leer();

            if(lista.Count <= 3)
            {
                mensajeActivacion(); 
            }
            else
            {
                mensajeDesactivacion();
            }
            desactivarBorrado.Invoke();
        }
    }
}
