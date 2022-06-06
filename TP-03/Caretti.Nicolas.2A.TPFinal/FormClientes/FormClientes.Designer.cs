
namespace FormClientes
{
    partial class FormClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBorrarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnCofirmarBorrado = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblBorrado = new System.Windows.Forms.Label();
            this.btnCancelarBorrado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(624, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.Location = new System.Drawing.Point(396, 32);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(102, 44);
            this.btnBorrarCliente.TabIndex = 1;
            this.btnBorrarCliente.Text = "Borrar Cliente";
            this.btnBorrarCliente.UseVisualStyleBackColor = true;
            this.btnBorrarCliente.Click += new System.EventHandler(this.btnBorrarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(251, 32);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(102, 44);
            this.btnAgregarCliente.TabIndex = 3;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnCofirmarBorrado
            // 
            this.btnCofirmarBorrado.Location = new System.Drawing.Point(159, 108);
            this.btnCofirmarBorrado.Name = "btnCofirmarBorrado";
            this.btnCofirmarBorrado.Size = new System.Drawing.Size(115, 23);
            this.btnCofirmarBorrado.TabIndex = 4;
            this.btnCofirmarBorrado.Text = "Confirmar Borrado";
            this.btnCofirmarBorrado.UseVisualStyleBackColor = true;
            this.btnCofirmarBorrado.Visible = false;
            this.btnCofirmarBorrado.Click += new System.EventHandler(this.btnCofirmarBorrado_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(42, 109);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 5;
            this.txtDni.Visible = false;
            // 
            // lblBorrado
            // 
            this.lblBorrado.AutoSize = true;
            this.lblBorrado.Location = new System.Drawing.Point(42, 91);
            this.lblBorrado.Name = "lblBorrado";
            this.lblBorrado.Size = new System.Drawing.Size(71, 15);
            this.lblBorrado.TabIndex = 6;
            this.lblBorrado.Text = "Ingrese DNI ";
            this.lblBorrado.Visible = false;
            // 
            // btnCancelarBorrado
            // 
            this.btnCancelarBorrado.Location = new System.Drawing.Point(280, 108);
            this.btnCancelarBorrado.Name = "btnCancelarBorrado";
            this.btnCancelarBorrado.Size = new System.Drawing.Size(115, 23);
            this.btnCancelarBorrado.TabIndex = 7;
            this.btnCancelarBorrado.Text = "Cancelar";
            this.btnCancelarBorrado.UseVisualStyleBackColor = true;
            this.btnCancelarBorrado.Visible = false;
            this.btnCancelarBorrado.Click += new System.EventHandler(this.btnCancelarBorrado_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 347);
            this.Controls.Add(this.btnCancelarBorrado);
            this.Controls.Add(this.lblBorrado);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnCofirmarBorrado);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnBorrarCliente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBorrarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnCofirmarBorrado;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblBorrado;
        private System.Windows.Forms.Button btnCancelarBorrado;
    }
}

