using System.ComponentModel;

namespace Parcial2
{
    partial class PedidosProducto
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
            this.dataGriw1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.dataGriw1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGriw1
            // 
            this.dataGriw1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriw1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGriw1.Location = new System.Drawing.Point(0, 0);
            this.dataGriw1.Name = "dataGriw1";
            this.dataGriw1.Size = new System.Drawing.Size(933, 519);
            this.dataGriw1.TabIndex = 0;
            // 
            // PedidosProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.dataGriw1);
            this.Name = "PedidosProducto";
            this.Text = "PedidosProducto";
            ((System.ComponentModel.ISupportInitialize) (this.dataGriw1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGriw1;
    }
}