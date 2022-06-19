using System;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormMenuEmpleados : Form, IVolverMenuPrincipal
    {
        EmpleadoDAO empleadoDAO;
        

        public FormMenuEmpleados()
        {
            InitializeComponent();
            empleadoDAO = new EmpleadoDAO();
        }

        /// <summary>
        /// Metodo que desactiva el boton de borrado, utilizado para eventos y delegados.
        /// </summary>
        private void EmpleadoDAO_desactivarBorrado()
        {
            btnBorrar.Enabled = false;
        }

        /// <summary>
        /// Metodo que activa el boton de borrado, utilizado para eventos y delegados.
        /// </summary>
        private void EmpleadoDAO_activarBorrado()
        {
            btnBorrar.Enabled = true;
        }

        /// <summary>
        /// Metodo que establece un mensaje en el label, utilizado para eventos y delegados.
        /// </summary>
        private void EmpleadoDAO_MensajeActivado()
        {
            lblMensaje.Text = $"Hay menos de 4 empleados en lista, opcion Borrar deshabilitada.";
        }

        /// <summary>
        /// Metodo que establece un mensaje en el label, utilizado para eventos y delegados.
        /// </summary>
        private void EmpleadoDAO_MensajeDesactivado()
        {
            lblMensaje.Text = $"NOTA: Si solo hay 3 empleados, la opcion Borrar sera desactivada.";
        }

        /// <summary>
        /// Metodo asincrono del tema Hilos que simula una gran carga de empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void FormMenuEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                this.lblCargaEmp.Text = "Cargando Empleados...";
                this.lblCargaEmp.Text = await EmpleadoDAO.CargarEmpleadosAsync();
                ActualizarEmpleados();
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error al leer la base de datos.");
            }
        }

        /// <summary>
        /// Metodo que agrega un empleado creado en el formulario FormAgregarEmpleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FormAgregarEmpleado f = new();
                this.Hide();

                DialogResult resultado = f.ShowDialog();
                this.Show();

                if (resultado == DialogResult.OK)
                {
                    empleadoDAO.Guardar(f.RetornoEmpleado);
                    this.ActualizarEmpleados();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al querer agregar una venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo que hace visible las opciones para borrar un empleado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblLegajo.Visible = true;
            txtLegajo.Visible = true;
            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
        }

        /// <summary>
        /// Metodo que confirma el borrado de un empleado a travez de el legajo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool legajoOk = false;
            bool esCliente = false;
            int legajoABorrar;

            try
            {
                if(txtLegajo.Text == "")
                {
                    throw new CampoVacioException();
                }
                else
                {
                    legajoOk = true;
                }
            }
            catch(CampoVacioException)
            {
                MessageBox.Show("Ingrese un legajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(legajoOk)
            {
                if(!int.TryParse(txtLegajo.Text, out legajoABorrar))
                {
                    MessageBox.Show("Ingrese un valor numerico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (Empleado item in empleadoDAO.Leer())
                    {
                        if(item.Legajo == legajoABorrar)
                        {
                            try
                            {
                                empleadoDAO.Eliminar(item.Legajo);
                                esCliente = true;
                                break;
                            }
                            catch(Exception)
                            {
                                MessageBox.Show("Ocurrio un error al eliminar el empleado.");
                            }
                        }
                    }

                    if(!esCliente)
                    {
                        MessageBox.Show("No se encontro ningun empleado con el legajo ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            MessageBox.Show("Empleado borrado con exito.");
                            ActualizarEmpleados();
                            ResetearOpcionBorrado();
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Ocurrio un error al leer la base de datos.");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Metodo que cancela la opcion de borrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetearOpcionBorrado();
        }

        /// <summary>
        /// Metodo que testea que la conexion con la base de datos es funcional.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            if (empleadoDAO.ProbarConexion())
            {
                MessageBox.Show("Prueba de conexion exitosa!");
            }
            else
            {
                MessageBox.Show("Prueba de conexion fallida.");
            }
        }

        /// <summary>
        /// Metodo que permite volver al menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            ((IVolverMenuPrincipal)this).VolverAlMenuPrincipal();
        }

        /// <summary>
        /// Implementacion de la interfaz que permite crear un objeto de todo formMenuPrincipal y cierra el form actual
        /// </summary>
        void IVolverMenuPrincipal.VolverAlMenuPrincipal()
        {
            FormMenuPrincipal f = new();
            f.Show();
            this.Close();
        }

        /// <summary>
        /// Metodo que actualiza la lista de empleados luego de cualquier cambio, a su vez implementa Eventos y Delegados.
        /// </summary>
        private void ActualizarEmpleados()
        {
            try
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = empleadoDAO.Leer();

                if (dgvEmpleados.Rows.Count > 0)
                {
                    this.lblCargaEmp.Text = $"El total es de {dgvEmpleados.Rows.Count} empleados.";
                }

                if (dgvEmpleados.Rows.Count <= 3)
                {
                    empleadoDAO.desactivarBorrado += null;
                    empleadoDAO.desactivarBorrado += EmpleadoDAO_desactivarBorrado;
                }
                else
                {
                    empleadoDAO.desactivarBorrado += null;
                    empleadoDAO.desactivarBorrado += EmpleadoDAO_activarBorrado;

                }
                empleadoDAO.LimiteEmpleadosABorrar(EmpleadoDAO_MensajeActivado, EmpleadoDAO_MensajeDesactivado);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error al intentar actualizar los empleados.");
            }

        }

        /// <summary>
        /// Metodo que le quita la visibilidad a las opciones de borrado
        /// </summary>
        private void ResetearOpcionBorrado()
        {
            lblLegajo.Visible = false;
            txtLegajo.Visible = false;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;

            txtLegajo.Text = "";
        }

        /// <summary>
        /// Metodo que instancia y muestra el formulario de modificaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarEmpleado f = new();
            f.Show();
        }
    }
}
