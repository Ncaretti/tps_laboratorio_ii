using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormMenuVentas f = new();
            f.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormMenuClientes f = new();
            f.Show();
            this.Hide();
        }

        private void btnSkins_Click(object sender, EventArgs e)
        {
            FormMenuSkins f = new();
            f.Show();
            this.Hide();
        }
    }
}