using System.ComponentModel;

namespace Parcial2.Properties
{
    partial class CambiarContra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.Nuevacontraseña = new System.Windows.Forms.Label();
            this.RepetirNuevaContraseña = new System.Windows.Forms.Label();
            this.txtRepetirNueva = new System.Windows.Forms.TextBox();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(252, 91);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Size = new System.Drawing.Size(207, 23);
            this.txtNueva.TabIndex = 0;
            // 
            // Nuevacontraseña
            // 
            this.Nuevacontraseña.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Nuevacontraseña.ForeColor = System.Drawing.Color.White;
            this.Nuevacontraseña.Location = new System.Drawing.Point(59, 91);
            this.Nuevacontraseña.Name = "Nuevacontraseña";
            this.Nuevacontraseña.Size = new System.Drawing.Size(159, 21);
            this.Nuevacontraseña.TabIndex = 1;
            this.Nuevacontraseña.Text = "Nueva contraseña:";
            // 
            // RepetirNuevaContraseña
            // 
            this.RepetirNuevaContraseña.Font = new System.Drawing.Font("Segoe UI Symbol", 12F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.RepetirNuevaContraseña.ForeColor = System.Drawing.Color.White;
            this.RepetirNuevaContraseña.Location = new System.Drawing.Point(42, 147);
            this.RepetirNuevaContraseña.Name = "RepetirNuevaContraseña";
            this.RepetirNuevaContraseña.Size = new System.Drawing.Size(176, 21);
            this.RepetirNuevaContraseña.TabIndex = 3;
            this.RepetirNuevaContraseña.Text = "Repita la contraseña:";
            // 
            // txtRepetirNueva
            // 
            this.txtRepetirNueva.Location = new System.Drawing.Point(252, 147);
            this.txtRepetirNueva.Name = "txtRepetirNueva";
            this.txtRepetirNueva.Size = new System.Drawing.Size(207, 23);
            this.txtRepetirNueva.TabIndex = 2;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Segoe UI Symbol", 12F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCambiarContraseña.Location = new System.Drawing.Point(167, 239);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(184, 58);
            this.btnCambiarContraseña.TabIndex = 4;
            this.btnCambiarContraseña.Text = "Cambiar";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(252, 28);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(207, 23);
            this.cmbUsuario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de usuario:";
            // 
            // CambiarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(534, 309);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.RepetirNuevaContraseña);
            this.Controls.Add(this.txtRepetirNueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nuevacontraseña);
            this.Controls.Add(this.txtNueva);
            this.Name = "CambiarContra";
            this.Text = "CambiarContra";
            this.Load += new System.EventHandler(this.CambiarContra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Label RepetirNuevaContraseña;
        private System.Windows.Forms.Label Nuevacontraseña;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.TextBox txtRepetirNueva;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Label label1;
    }
}