using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Armas;
using Serializacion;

namespace FormSkins
{
    public partial class FormSkins : Form
    {
        List<Arma> listaArmas = ClaseSerializadora<List<Arma>>.Leer("lista");

        public FormSkins()
        {
            InitializeComponent();
        }

        private void FormSkins_Load(object sender, EventArgs e)
        {
            List<Arma> listaArmas = ClaseSerializadora<List<Arma>>.Leer("lista");
            try
            {
                foreach (Arma item in listaArmas)
                {
                    lstSkins.Items.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al querer cargar la lista en el ListBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo que muestra el formulario de carga de skins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarSkin_Click(object sender, EventArgs e)
        {
            FormAgregarSkin f = new FormAgregarSkin();
            f.Show();
            this.Hide();
        }

        /// <summary>
        /// Metodo que borra el skin seleccionado en el listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarSkin_Click(object sender, EventArgs e)
        {
            try
            {
                listaArmas.Remove((Arma)lstSkins.SelectedItem);
                lstSkins.Items.Remove(lstSkins.SelectedItem);

                ClaseSerializadora<List<Arma>>.Escribir(listaArmas, "lista");
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error al querer borrar un arma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
