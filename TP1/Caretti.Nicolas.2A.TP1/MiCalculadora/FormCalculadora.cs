using System;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo del evento click del boton Cerrar que se encarga
        /// de mostrar un Mensaje de confirmacion de cierre del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Metodo del evento click del boton Convertir a Binario que se encarga
        /// de transformar el resultado decimal en binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = lblResultado.Text;
            string resultadoBinario = Operando.DecimalBinario(lblResultado.Text); 
            lblResultado.Text = resultadoBinario;

            if(double.TryParse(resultado, out double num))
            {
                double numAbs = Math.Abs(num);
                lstOperaciones.Items.Add("DaB de " + Math.Truncate(numAbs) + " =" + resultadoBinario.ToString());
            }
        }

        /// <summary>
        /// Metodo del evento click del boton Convertir a Decimal que se encarga
        /// de transformar el resultado binario en decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultado = lblResultado.Text;
            string resultadoDecimal = Operando.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = resultadoDecimal;
            lstOperaciones.Items.Add("BaD de " + resultado + " =" + resultadoDecimal.ToString());
        }

        /// <summary>
        /// Metodo del evento click del boton Limpiar que se encarga
        /// de invocar al metodo Limpiar()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Metodo del evento click del boton Operar que se encarga
        /// de asignarle un valor por defecto al operador, invocar al metodo Operar() y
        /// mostrar el calculo realizado en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (cmbOperador.Text == string.Empty)
            {
                cmbOperador.Text = "+";
            }

            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            lblResultado.Text = resultado.ToString();
            lstOperaciones.Items.Add(txtNumero1.Text + cmbOperador.Text + txtNumero2.Text + "=" + resultado.ToString()); 
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Metodo encargado de "Vaciar/Limpiar" los textbox, el label y el combobox
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "0";
            this.cmbOperador.SelectedItem = "";
        }

        /// <summary>
        /// Metodo que realiza la operacion deseada segun los parametros recibidos
        /// </summary>
        /// <param name="numero1">primer numero</param>
        /// <param name="numero2">segundo numero</param>
        /// <param name="operador">operador</param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            if (numero2 == "0" && operador == "/")
            {
                MessageBox.Show("No se puede dividir por cero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Calculadora.Operar(num1, num2, Convert.ToChar(operador));
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
