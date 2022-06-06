using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ventas;
using Serializacion;
using Armas;

namespace FormVentas
{

    public partial class FormVentas : Form
    {
        List<Venta> listaVentas = ClaseSerializadora<List<Venta>>.Leer("ventas");

        public FormVentas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del formulario y de la lista de Ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVentas_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaVentas;
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error al querer agregar el DataGrid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Metodo encargado de cargar el cliente creado en FormAgregarCliente en el archivo XML y tambien actualizar
        /// el datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                FormAgregarVenta f = new();

                DialogResult resultado = f.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    listaVentas.Add(f.RetornarVenta);
                    ClaseSerializadora<List<Venta>>.EscribirVentas(listaVentas, "ventas");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listaVentas;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error al querer agregar una venta","Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            
        }

        private void btnCrearTicket_Click(object sender, EventArgs e)
        {
            int index = -1;

            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    index = row.Index;
                }

                if (index != -1)
                {
                    int dni = listaVentas[index].Dni;
                    string nombre = listaVentas[index].Nombre;
                    string apellido = listaVentas[index].Apellido;

                    string nombreArma = listaVentas[index].NombreTipoArma;
                    string nombreSkin = listaVentas[index].NombreSkin;
                    double precio = listaVentas[index].Precio;

                    Archivos.Escribir(nombre, apellido, dni, nombreArma, nombreSkin, precio);
                    MessageBox.Show("Ticket generado con exito.");
                }
                else
                {
                    MessageBox.Show("Error al generar el ticket.", "Error", MessageBoxButtons.OK);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error al generar el ticket.", "Error", MessageBoxButtons.OK);
            }
            
        }
    }
}
