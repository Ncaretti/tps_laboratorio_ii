using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Clientes;
using Excepciones;
using Serializacion;

namespace FormClientes
{
    public partial class FormClientes : Form
    {
        List<Cliente> listaClientes = ClaseSerializadora<List<Cliente>>.LeerJson("listaClientes");

        public FormClientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del formulario, utilizado tambien para cargar los datos del JSON en el DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClientes_Load(object sender, EventArgs e)
        {
            /*List<Cliente> listaClientes = new List<Cliente>()
            {
                    new Cliente(40502931, "Walter", "Pereyra", 0),
                    new Cliente(45319037, "Lazaro", "Guzman", 0),
                    new Cliente(38028341, "Agustin", "Rosales", 0)
            };

            ClaseSerializadoraJson<List<Cliente>>.Escribir(listaClientes, "lista");*/
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaClientes;
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error al querer cargar el DataGrid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Metodo que se encarga de cargar y escribir el Cliente creado tanto en el JSON como en el Datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FormAgregarCliente f = new FormAgregarCliente();
                DialogResult resultado = f.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    listaClientes.Add(f.RetornarCliente);
                    ClaseSerializadora<List<Cliente>>.EscribirJson(listaClientes, "listaClientes");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listaClientes;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error al querer agregar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo encargado de habilitar los textBox, labels y botones necesarios para la eliminacion de un Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            btnCofirmarBorrado.Visible = true;
            txtDni.Visible = true;
            lblBorrado.Visible = true;
            btnCancelarBorrado.Visible = true;
        }

        /// <summary>
        /// Metodo encargado de corroborar que el DNI del cliente ingresado coincida con uno de la lista y lo borra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCofirmarBorrado_Click(object sender, EventArgs e)
        {
           int dniABorrar;
            bool esCliente = false;
            bool camposOk = false;

            try
            {
                if (txtDni.Text == "")
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
                MessageBox.Show("Ingrese un DNI.", "Error", MessageBoxButtons.OK);
            }

            if(camposOk)
            {
                if (!int.TryParse(txtDni.Text, out dniABorrar))
                {
                    MessageBox.Show("Ingrese un valor numerico.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    foreach (Cliente item in listaClientes)
                    {
                        if (item.Dni == dniABorrar)
                        {
                            listaClientes.Remove(item);
                            esCliente = true;
                            break;
                        }
                    }

                    if (esCliente == false)
                    {
                        MessageBox.Show("No se encontro ningun cliente con el DNI ingresado.", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Cliente borrado con exito.");
                        ClaseSerializadora<List<Cliente>>.EscribirJson(listaClientes, "listaClientes");
                        ClaseSerializadora<List<Cliente>>.LeerJson("listaClientes");

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = listaClientes;
                        btnCofirmarBorrado.Visible = false;
                        txtDni.Visible = false;
                        lblBorrado.Visible = false;

                    }
                }
            }
        }

        /// <summary>
        /// Metodo encargado de ocultar los label, textBox y botones del apartado de eliminacion de cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelarBorrado_Click(object sender, EventArgs e)
        {
            btnCofirmarBorrado.Visible = false;
            btnCancelarBorrado.Visible = false;
            txtDni.Visible = false;
            lblBorrado.Visible = false;
            txtDni.Text = "";
        }
    }
}
