﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormMenuSkins : Form, IVolverMenuPrincipal
    {
        List<Arma> listaArmas = ClaseSerializadora<List<Arma>>.Leer("lista");

        public FormMenuSkins()
        {
            InitializeComponent();
        }

        private async void FormSkins_Load(object sender, EventArgs e)
        {
            listaArmas = ClaseSerializadora<List<Arma>>.Leer("lista");
            this.lblCarga.Text = "Cargando Lista...";
            this.lblCarga.Text = await ClaseSerializadora<List<Arma>>.CargarListasAsync();
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
            if (listaArmas.Count > 0)
            {
                this.lblCarga.Text += $" Se cargaron en total {listaArmas.Count} elementos.";
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
            lblCarga.Text = $"Se modifico la cantidad de skins, skins actuales : {listaArmas.Count}";
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
                if(listaArmas.Remove((Arma)lstSkins.SelectedItem))
                {
                    lstSkins.Items.Remove(lstSkins.SelectedItem);
                    ClaseSerializadora<List<Arma>>.Escribir(listaArmas, "lista");
                    MessageBox.Show("Arma elminada con exito.");
                    lblCarga.Text = $"Se modifico la cantidad de skins, skins actuales : {listaArmas.Count}";
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error al querer borrar un arma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
