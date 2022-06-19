using System;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormModificarEmpleado : Form
    {
        EmpleadoDAO empleadoDAO = new EmpleadoDAO();

        /// <summary>
        /// Constructor que carga la base de datos en una lista auxiliar
        /// </summary>
        public FormModificarEmpleado()
        {
            InitializeComponent();
            try
            {
                lstEmpleadosAux.DataSource = empleadoDAO.Leer();
            }
            catch(Exception)
            {
                MessageBox.Show("No se pudo cargar los datos de la base de datos en la lista.");
            }
            
        }

        /// <summary>
        /// Metodo que maneja al evento doble click de la lista, el cual setea en unos textbox los datos del empleado clickeado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstEmpleadosAux_DoubleClick(object sender, EventArgs e)
        {
            Empleado empleado = lstEmpleadosAux.SelectedItem as Empleado;
            if (empleado is not null)
            {
                txtNombre.Text = empleado.Nombre;
                txtApellido.Text = empleado.Apellido;
                txtSueldo.Text = empleado.Sueldo.ToString();
            }
        }

        /// <summary>
        /// Metodo que confirma la modificacion del empleado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            FormMenuEmpleados f = new();
            float sueldo;

            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && float.TryParse(txtSueldo.Text, out sueldo))
                {
                    Empleado empleadoSeleccionado = lstEmpleadosAux.SelectedItem as Empleado;

                    Empleado nuevoEmpleado = new Empleado(txtNombre.Text, txtApellido.Text, empleadoSeleccionado.Dni, empleadoSeleccionado.Puesto, sueldo);

                    if (empleadoSeleccionado is not null)
                    {
                        empleadoDAO.Modificar(empleadoSeleccionado.Legajo, nuevoEmpleado);
                        f.Show();
                        this.Close();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error en la modificacion, revisar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo que cancela la opcion de modificacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de cancelar la modificacion?", "Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
