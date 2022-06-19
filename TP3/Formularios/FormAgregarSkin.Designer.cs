
namespace Formularios
{
    partial class FormAgregarSkin
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
            this.txtNombreSkin = new System.Windows.Forms.TextBox();
            this.lblNombreSkin = new System.Windows.Forms.Label();
            this.cmbCalidadArma = new System.Windows.Forms.ComboBox();
            this.lblCalidad = new System.Windows.Forms.Label();
            this.lblArma = new System.Windows.Forms.Label();
            this.btnConfirmarSkin = new System.Windows.Forms.Button();
            this.rdioCuchillo = new System.Windows.Forms.RadioButton();
            this.rdioArmaDeFuego = new System.Windows.Forms.RadioButton();
            this.cmbTipoArma = new System.Windows.Forms.ComboBox();
            this.lblTipoArma = new System.Windows.Forms.Label();
            this.txtFloatSkin = new System.Windows.Forms.TextBox();
            this.lblFloatSkin = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombreSkin
            // 
            this.txtNombreSkin.Location = new System.Drawing.Point(171, 138);
            this.txtNombreSkin.Name = "txtNombreSkin";
            this.txtNombreSkin.Size = new System.Drawing.Size(121, 23);
            this.txtNombreSkin.TabIndex = 0;
            this.txtNombreSkin.Visible = false;
            // 
            // lblNombreSkin
            // 
            this.lblNombreSkin.AutoSize = true;
            this.lblNombreSkin.Location = new System.Drawing.Point(171, 120);
            this.lblNombreSkin.Name = "lblNombreSkin";
            this.lblNombreSkin.Size = new System.Drawing.Size(94, 15);
            this.lblNombreSkin.TabIndex = 1;
            this.lblNombreSkin.Text = "Nombre del skin";
            this.lblNombreSkin.Visible = false;
            // 
            // cmbCalidadArma
            // 
            this.cmbCalidadArma.FormattingEnabled = true;
            this.cmbCalidadArma.Location = new System.Drawing.Point(171, 89);
            this.cmbCalidadArma.Name = "cmbCalidadArma";
            this.cmbCalidadArma.Size = new System.Drawing.Size(121, 23);
            this.cmbCalidadArma.TabIndex = 2;
            this.cmbCalidadArma.Visible = false;
            // 
            // lblCalidad
            // 
            this.lblCalidad.AutoSize = true;
            this.lblCalidad.Location = new System.Drawing.Point(172, 71);
            this.lblCalidad.Name = "lblCalidad";
            this.lblCalidad.Size = new System.Drawing.Size(130, 15);
            this.lblCalidad.TabIndex = 4;
            this.lblCalidad.Text = "Elija la calidad del arma";
            this.lblCalidad.Visible = false;
            // 
            // lblArma
            // 
            this.lblArma.AutoSize = true;
            this.lblArma.Location = new System.Drawing.Point(27, 57);
            this.lblArma.Name = "lblArma";
            this.lblArma.Size = new System.Drawing.Size(70, 15);
            this.lblArma.TabIndex = 5;
            this.lblArma.Text = "Elija el arma";
            // 
            // btnConfirmarSkin
            // 
            this.btnConfirmarSkin.Location = new System.Drawing.Point(12, 163);
            this.btnConfirmarSkin.Name = "btnConfirmarSkin";
            this.btnConfirmarSkin.Size = new System.Drawing.Size(134, 44);
            this.btnConfirmarSkin.TabIndex = 6;
            this.btnConfirmarSkin.Text = "Confirmar Skin";
            this.btnConfirmarSkin.UseVisualStyleBackColor = true;
            this.btnConfirmarSkin.Click += new System.EventHandler(this.btnConfirmarSkin_Click);
            // 
            // rdioCuchillo
            // 
            this.rdioCuchillo.AutoSize = true;
            this.rdioCuchillo.Location = new System.Drawing.Point(27, 79);
            this.rdioCuchillo.Name = "rdioCuchillo";
            this.rdioCuchillo.Size = new System.Drawing.Size(69, 19);
            this.rdioCuchillo.TabIndex = 7;
            this.rdioCuchillo.TabStop = true;
            this.rdioCuchillo.Text = "Cuchillo";
            this.rdioCuchillo.UseVisualStyleBackColor = true;
            this.rdioCuchillo.CheckedChanged += new System.EventHandler(this.rdioCuchillo_CheckedChanged);
            // 
            // rdioArmaDeFuego
            // 
            this.rdioArmaDeFuego.AutoSize = true;
            this.rdioArmaDeFuego.Location = new System.Drawing.Point(27, 104);
            this.rdioArmaDeFuego.Name = "rdioArmaDeFuego";
            this.rdioArmaDeFuego.Size = new System.Drawing.Size(104, 19);
            this.rdioArmaDeFuego.TabIndex = 8;
            this.rdioArmaDeFuego.TabStop = true;
            this.rdioArmaDeFuego.Text = "Arma de fuego";
            this.rdioArmaDeFuego.UseVisualStyleBackColor = true;
            this.rdioArmaDeFuego.CheckedChanged += new System.EventHandler(this.rdioArmaDeFuego_CheckedChanged);
            // 
            // cmbTipoArma
            // 
            this.cmbTipoArma.FormattingEnabled = true;
            this.cmbTipoArma.Location = new System.Drawing.Point(171, 38);
            this.cmbTipoArma.Name = "cmbTipoArma";
            this.cmbTipoArma.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoArma.TabIndex = 9;
            this.cmbTipoArma.Visible = false;
            // 
            // lblTipoArma
            // 
            this.lblTipoArma.AutoSize = true;
            this.lblTipoArma.Location = new System.Drawing.Point(171, 20);
            this.lblTipoArma.Name = "lblTipoArma";
            this.lblTipoArma.Size = new System.Drawing.Size(123, 15);
            this.lblTipoArma.TabIndex = 10;
            this.lblTipoArma.Text = "Tipo de arma/cuchillo";
            this.lblTipoArma.Visible = false;
            // 
            // txtFloatSkin
            // 
            this.txtFloatSkin.Location = new System.Drawing.Point(172, 185);
            this.txtFloatSkin.Name = "txtFloatSkin";
            this.txtFloatSkin.Size = new System.Drawing.Size(121, 23);
            this.txtFloatSkin.TabIndex = 11;
            this.txtFloatSkin.Visible = false;
            // 
            // lblFloatSkin
            // 
            this.lblFloatSkin.AutoSize = true;
            this.lblFloatSkin.Location = new System.Drawing.Point(172, 167);
            this.lblFloatSkin.Name = "lblFloatSkin";
            this.lblFloatSkin.Size = new System.Drawing.Size(135, 15);
            this.lblFloatSkin.TabIndex = 12;
            this.lblFloatSkin.Text = "Ingrese el Float del arma";
            this.lblFloatSkin.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 44);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(171, 216);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(81, 15);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Ingrese precio";
            this.lblPrecio.Visible = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(171, 234);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 23);
            this.txtPrecio.TabIndex = 15;
            this.txtPrecio.Visible = false;
            // 
            // FormAgregarSkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 288);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblFloatSkin);
            this.Controls.Add(this.txtFloatSkin);
            this.Controls.Add(this.lblTipoArma);
            this.Controls.Add(this.cmbTipoArma);
            this.Controls.Add(this.rdioArmaDeFuego);
            this.Controls.Add(this.rdioCuchillo);
            this.Controls.Add(this.btnConfirmarSkin);
            this.Controls.Add(this.lblArma);
            this.Controls.Add(this.lblCalidad);
            this.Controls.Add(this.cmbCalidadArma);
            this.Controls.Add(this.lblNombreSkin);
            this.Controls.Add(this.txtNombreSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarSkin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Skin";
            this.Load += new System.EventHandler(this.FormAgregarSkin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreSkin;
        private System.Windows.Forms.Label lblNombreSkin;
        private System.Windows.Forms.ComboBox cmbCalidadArma;
        private System.Windows.Forms.Label lblCalidad;
        private System.Windows.Forms.Label lblArma;
        private System.Windows.Forms.Button btnConfirmarSkin;
        private System.Windows.Forms.RadioButton rdioCuchillo;
        private System.Windows.Forms.RadioButton rdioArmaDeFuego;
        private System.Windows.Forms.ComboBox cmbTipoArma;
        private System.Windows.Forms.Label lblTipoArma;
        private System.Windows.Forms.TextBox txtFloatSkin;
        private System.Windows.Forms.Label lblFloatSkin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}