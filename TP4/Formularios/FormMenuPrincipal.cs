using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormMenuPrincipal : Form
    {
        FormMenuClientes f1 = new();
        FormMenuEmpleados f2 = new();
        FormMenuSkins f3 = new();
        FormMenuVentas f4 = new();

        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            f4.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }

        private void btnSkins_Click(object sender, EventArgs e)
        {
            f3.Show();
            this.Hide();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            f1.Close();
            f2.Close();
            f3.Close();
            f4.Close();
            this.Close();
        }
    }
}