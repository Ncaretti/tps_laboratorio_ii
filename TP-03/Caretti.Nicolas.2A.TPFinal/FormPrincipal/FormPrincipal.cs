using System;
using System.Windows.Forms;
using FormVentas;

namespace FormPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas.FormVentas fVentas = new();
            fVentas.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes.FormClientes fClientes = new();
            fClientes.Show();
        }

        private void btnSkins_Click(object sender, EventArgs e)
        {
            FormSkins.FormSkins fSkins = new();
            fSkins.Show();
        }
    }
}
