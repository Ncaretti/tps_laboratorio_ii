using System;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormAgregarEmpleado : Form
    {
        Empleado empleado;

        /// <summary>
        /// Propiedad utilizada para obtener un empleado.
        /// </summary>
        public Empleado RetornoEmpleado
        {
            get { return empleado; }
        }

        /// <summary>
        /// Constructor que carga las opciones del comboBox
        /// </summary>
        public FormAgregarEmpleado()
        {
            InitializeComponent();

            cmbPuesto.Items.Add(Empleado.EPuesto.Compras);
            cmbPuesto.Items.Add(Empleado.EPuesto.Marketing);
            cmbPuesto.Items.Add(Empleado.EPuesto.Ventas);
        }

        /// <summary>
        /// Metodo que verifica los datos y confirma al nuevo Empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool camposOk = false;
            int dni;
            float sueldo;

            try
            {
                if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "" || txtSueldo.Text == "" || cmbPuesto.SelectedItem == null)
                {
                    throw new CampoVacioException();
                }
                else
                {
                    camposOk = true;
                }
            }
            catch (CampoVacioException)
            {
                MessageBox.Show("Hay uno o mas campos del Empleado vacios.", "Error", MessageBoxButtons.OK);
            }

            if (camposOk)
            {
                try
                {
                    if (int.TryParse(txtDni.Text, out dni))
                    {
                        if(float.TryParse(txtSueldo.Text, out sueldo))
                        {
                            empleado = new Empleado();

                            empleado.Nombre = txtNombre.Text;
                            empleado.Apellido = txtApellido.Text;
                            empleado.Dni = dni;
                            empleado.Puesto = cmbPuesto.SelectedItem.ToString();
                            empleado.Sueldo = sueldo;

                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, revisar que el campo DNI y Sueldo sean numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Metodo que cancela la carga de un nuevo empleado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere cancelar la carga del empleado?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
