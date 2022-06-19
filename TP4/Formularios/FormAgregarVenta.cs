using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormAgregarVenta : Form
    {
        List<Cliente> listaClientes = ClaseSerializadora<List<Cliente>>.LeerJson("listaClientes");
        List<Arma> listaArmas = ClaseSerializadora<List<Arma>>.Leer("lista");
        List<Venta> listaVentas = ClaseSerializadora<List<Venta>>.Leer("ventas");
        Venta venta;

        public Venta RetornarVenta
        {
            get { return venta; }
        }

        public FormAgregarVenta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del formulario y de las listas correspondientes para realizar una Venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAgregarVenta_Load(object sender, EventArgs e)
        {
            dtagClientes.DataSource = null;
            dtagArmas.DataSource = null;

            dtagClientes.DataSource = listaClientes;
            dtagArmas.DataSource = listaArmas;
        }

        /// <summary>
        /// Metodo encargado de validar y crear una Venta a traves de validar y confirmar los datos de los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                FormMenuVentas f = new();
                venta = new Venta();
                int indexClientes = -1;
                int indexArmas = -1;

                foreach (DataGridViewRow row in dtagClientes.SelectedRows)
                {
                    indexClientes = row.Index;
                }

                foreach (DataGridViewRow row in dtagArmas.SelectedRows)
                {
                    indexArmas = row.Index;
                }

                if (indexClientes != -1 && indexArmas != -1)
                {
                    int dni = listaClientes[indexClientes].Dni;
                    string nombre = listaClientes[indexClientes].Nombre;
                    string apellido = listaClientes[indexClientes].Apellido;

                    string nombreArma = listaArmas[indexArmas].TipoArma.ToString();
                    string calidadArma = listaArmas[indexArmas].TipoCalidad.ToString();
                    string nombreSkin = listaArmas[indexArmas].NombreSkin;
                    double precio = listaArmas[indexArmas].Precio;

                    listaClientes[indexClientes].CantidadDeCompras++;
                    ClaseSerializadora<List<Cliente>>.EscribirJson(listaClientes, "listaClientes");

                    venta = new Venta(dni, nombre, apellido, nombreArma, calidadArma, nombreSkin, precio, DateTime.Now);
                    listaVentas.Add(venta);
                    MessageBox.Show("Venta generada con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al querer confirmar una venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormMenuVentas f = new();
            f.Show();
            this.Close();
        }
    }
}
