using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormAgregarSkin : Form
    {
        List<Arma> listaArmas = ClaseSerializadora<List<Arma>>.Leer("lista");

        public FormAgregarSkin()
        {
            InitializeComponent();

        }

        private void FormAgregarSkin_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirmarSkin_Click(object sender, EventArgs e)
        {
            double floatSkin;
            double precio;
            bool camposOk = false;
            FormMenuSkins f = new FormMenuSkins();

            if (rdioCuchillo.Checked is true)
            {
                try
                {
                    if (cmbTipoArma.Text == "" || txtNombreSkin.Text == "" || txtPrecio.Text == "")
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
                    MessageBox.Show("Hay uno o mas campos del Cuchillo vacios.", "Error", MessageBoxButtons.OK);
                }

                if (camposOk)
                {
                    if (!double.TryParse(txtPrecio.Text, out precio))
                    {
                        MessageBox.Show("Error, ingrese precio valido.", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Cuchillo ar = new Cuchillo((Arma.ETipoArma)cmbTipoArma.SelectedItem, txtNombreSkin.Text, precio);
                        listaArmas.Add(ar);
                        ClaseSerializadora<List<Arma>>.Escribir(listaArmas, "lista");
                        f.Show();
                        Close();
                    }

                }
            }

            if (rdioArmaDeFuego.Checked is true)
            {
                try
                {
                    if (cmbTipoArma.Text == "" || cmbCalidadArma.Text == "" || txtNombreSkin.Text == "" || txtFloatSkin.Text == "" || txtPrecio.Text == "")
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
                    MessageBox.Show("Hay uno o mas campos del Arma vacios.", "Error", MessageBoxButtons.OK);
                }

                if (camposOk)
                {
                    if (!double.TryParse(txtFloatSkin.Text, out floatSkin) || floatSkin >= 1 || floatSkin <= 0 && double.TryParse(txtPrecio.Text, out precio))
                    {
                        MessageBox.Show("Error, ingrese un numero entre 0 y 0.99 en el Float.", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (!double.TryParse(txtPrecio.Text, out precio))
                        {
                            MessageBox.Show("Error, ingrese precio valido.", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            ArmaDeFuego ar = new ArmaDeFuego((Arma.ETipoArma)cmbTipoArma.SelectedItem, (Arma.ECalidadArma)cmbCalidadArma.SelectedItem, txtNombreSkin.Text, precio, floatSkin);
                            listaArmas.Add(ar);
                            ClaseSerializadora<List<Arma>>.Escribir(listaArmas, "lista");
                            f.Show();
                            Close();
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cancelar la carga de la skin?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormMenuSkins f = new FormMenuSkins();
                f.Show();
                Close();
            }
        }

        private void rdioCuchillo_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreSkin.Location = new System.Drawing.Point(171, 75);
            lblNombreSkin.Location = new System.Drawing.Point(171, 57);
            cmbTipoArma.Location = new System.Drawing.Point(171, 126);
            lblTipoArma.Location = new System.Drawing.Point(171, 108);
            txtPrecio.Location = new System.Drawing.Point(171, 170);
            lblPrecio.Location = new System.Drawing.Point(171, 154);
            cmbTipoArma.Items.Clear();
            cmbCalidadArma.Items.Clear();
            cmbCalidadArma.Text = "";
            cmbTipoArma.Text = "";
            txtPrecio.Text = "";

            cmbTipoArma.Items.Add(Arma.ETipoArma.Karambit);
            cmbTipoArma.Items.Add(Arma.ETipoArma.Bayoneta);

            txtPrecio.Visible = true;
            lblPrecio.Visible = true;
            lblCalidad.Visible = false;
            cmbCalidadArma.Visible = false;
            lblFloatSkin.Visible = false;
            txtFloatSkin.Visible = false;
            lblTipoArma.Visible = true;
            cmbTipoArma.Visible = true;
            txtNombreSkin.Visible = true;
            lblNombreSkin.Visible = true;
        }

        private void rdioArmaDeFuego_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreSkin.Location = new System.Drawing.Point(171, 138);
            lblNombreSkin.Location = new System.Drawing.Point(171, 120);
            cmbTipoArma.Location = new System.Drawing.Point(171, 38);
            lblTipoArma.Location = new System.Drawing.Point(171, 20);
            lblPrecio.Location = new System.Drawing.Point(171, 216);
            txtPrecio.Location = new System.Drawing.Point(171, 234);

            cmbTipoArma.Items.Clear();
            cmbCalidadArma.Items.Clear();
            cmbCalidadArma.Text = "";
            cmbTipoArma.Text = "";

            cmbTipoArma.Items.Add(Arma.ETipoArma.Desert_Eagle);
            cmbTipoArma.Items.Add(Arma.ETipoArma.Ak_47);
            cmbCalidadArma.Items.Add(Arma.ECalidadArma.Azul);
            cmbCalidadArma.Items.Add(Arma.ECalidadArma.Violeta);
            cmbCalidadArma.Items.Add(Arma.ECalidadArma.Rosa);
            cmbCalidadArma.Items.Add(Arma.ECalidadArma.Roja);

            txtPrecio.Visible = true;
            lblPrecio.Visible = true;
            lblTipoArma.Visible = true;
            cmbTipoArma.Visible = true;
            lblFloatSkin.Visible = true;
            txtFloatSkin.Visible = true;
            lblCalidad.Visible = true;
            cmbCalidadArma.Visible = true;
            txtNombreSkin.Visible = true;
            lblNombreSkin.Visible = true;
        }
    }
}
