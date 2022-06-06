using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Clientes;
using Excepciones;
using Serializacion;

namespace FormClientes
{
    public partial class FormAgregarCliente : Form
    {
        Cliente cliente;
        List<Cliente> listaClientes = ClaseSerializadora<List<Cliente>>.LeerJson("listaClientes");

        /// <summary>
        /// Propiedad utilizada para obtener un cliente
        /// </summary>
        public Cliente RetornarCliente
        {
            get { return cliente; }
        }

        public FormAgregarCliente()
        {
            InitializeComponent();
        }

        public FormAgregarCliente(List<Cliente> listaClientes) : this()
        {
            this.listaClientes = listaClientes;
        }

        /// <summary>
        /// Metodo encargado de agregar un cliente a la lista realizando previas validaciones de los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool camposOk = false;

            try
            {
                if (txtDni.Text == "" || txtNombre.Text == "" || txtApellido.Text == "")
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
                MessageBox.Show("Hay uno o mas campos del Cliente vacios.", "Error", MessageBoxButtons.OK);
            }

            if(camposOk)
            {
                try
                {
                    cliente = new Cliente();

                    cliente.Dni = int.Parse(txtDni.Text);
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.CantidadDeCompras = 0;

                    listaClientes.Add(cliente);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error al querer confirmar un cliente, revisar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Metodo encargado de cancelar la carga de un nuevo Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere cancelar la carga del cliente?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}