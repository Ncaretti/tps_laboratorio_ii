
namespace Formularios
{
    partial class FormAgregarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtagClientes = new System.Windows.Forms.DataGridView();
            this.dtagArmas = new System.Windows.Forms.DataGridView();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtagClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtagArmas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtagClientes
            // 
            this.dtagClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtagClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagClientes.Location = new System.Drawing.Point(12, 92);
            this.dtagClientes.Name = "dtagClientes";
            this.dtagClientes.ReadOnly = true;
            this.dtagClientes.RowTemplate.Height = 25;
            this.dtagClientes.Size = new System.Drawing.Size(484, 270);
            this.dtagClientes.TabIndex = 0;
            // 
            // dtagArmas
            // 
            this.dtagArmas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtagArmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagArmas.Location = new System.Drawing.Point(520, 92);
            this.dtagArmas.Name = "dtagArmas";
            this.dtagArmas.ReadOnly = true;
            this.dtagArmas.RowTemplate.Height = 25;
            this.dtagArmas.Size = new System.Drawing.Size(467, 270);
            this.dtagArmas.TabIndex = 1;
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.Location = new System.Drawing.Point(392, 34);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(104, 37);
            this.btnConfirmarVenta.TabIndex = 2;
            this.btnConfirmarVenta.Text = "Confirmar Venta";
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(520, 34);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormAgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(999, 374);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.dtagArmas);
            this.Controls.Add(this.dtagClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Venta";
            this.Load += new System.EventHandler(this.FormAgregarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtagClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtagArmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtagClientes;
        private System.Windows.Forms.DataGridView dtagArmas;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnCancelar;
    }
}