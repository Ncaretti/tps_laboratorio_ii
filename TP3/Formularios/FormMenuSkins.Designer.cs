
namespace Formularios
{
    partial class FormMenuSkins
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
            this.lstSkins = new System.Windows.Forms.ListBox();
            this.btnAgregarSkin = new System.Windows.Forms.Button();
            this.btnBorrarSkin = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSkins
            // 
            this.lstSkins.BackColor = System.Drawing.SystemColors.Window;
            this.lstSkins.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstSkins.FormattingEnabled = true;
            this.lstSkins.ItemHeight = 15;
            this.lstSkins.Location = new System.Drawing.Point(296, 8);
            this.lstSkins.Name = "lstSkins";
            this.lstSkins.Size = new System.Drawing.Size(379, 334);
            this.lstSkins.TabIndex = 0;
            // 
            // btnAgregarSkin
            // 
            this.btnAgregarSkin.Location = new System.Drawing.Point(41, 43);
            this.btnAgregarSkin.Name = "btnAgregarSkin";
            this.btnAgregarSkin.Size = new System.Drawing.Size(131, 52);
            this.btnAgregarSkin.TabIndex = 1;
            this.btnAgregarSkin.Text = "Agregar skin";
            this.btnAgregarSkin.UseVisualStyleBackColor = true;
            this.btnAgregarSkin.Click += new System.EventHandler(this.btnAgregarSkin_Click);
            // 
            // btnBorrarSkin
            // 
            this.btnBorrarSkin.Location = new System.Drawing.Point(41, 110);
            this.btnBorrarSkin.Name = "btnBorrarSkin";
            this.btnBorrarSkin.Size = new System.Drawing.Size(131, 52);
            this.btnBorrarSkin.TabIndex = 3;
            this.btnBorrarSkin.Text = "Borrar skin";
            this.btnBorrarSkin.UseVisualStyleBackColor = true;
            this.btnBorrarSkin.Click += new System.EventHandler(this.btnBorrarSkin_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(41, 179);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 52);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver al Menu Principal";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormMenuSkins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 358);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBorrarSkin);
            this.Controls.Add(this.btnAgregarSkin);
            this.Controls.Add(this.lstSkins);
            this.Name = "FormMenuSkins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skins";
            this.Load += new System.EventHandler(this.FormSkins_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBorrarSkin;
        public System.Windows.Forms.ListBox lstSkins;
        public System.Windows.Forms.Button btnAgregarSkin;
        private System.Windows.Forms.Button btnVolver;
    }
}

