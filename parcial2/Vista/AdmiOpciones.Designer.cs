﻿using System.ComponentModel;

namespace Parcial2
{
    partial class AdmiOpciones
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
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnNegocios = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUsuarios.Location = new System.Drawing.Point(24, 34);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(515, 63);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Modificar usuario";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnNegocios
            // 
            this.btnNegocios.BackColor = System.Drawing.Color.White;
            this.btnNegocios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNegocios.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnNegocios.Location = new System.Drawing.Point(24, 148);
            this.btnNegocios.Name = "btnNegocios";
            this.btnNegocios.Size = new System.Drawing.Size(515, 63);
            this.btnNegocios.TabIndex = 1;
            this.btnNegocios.Text = "Negocio Opciones";
            this.btnNegocios.UseVisualStyleBackColor = false;
            this.btnNegocios.Click += new System.EventHandler(this.btnNegocios_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.White;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnProductos.Location = new System.Drawing.Point(24, 245);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(515, 62);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Menu de productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.White;
            this.btnOrdenes.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnOrdenes.Location = new System.Drawing.Point(24, 349);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(515, 62);
            this.btnOrdenes.TabIndex = 3;
            this.btnOrdenes.Text = "Vizualizar ordenadas";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // AdmiOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(570, 468);
            this.Controls.Add(this.btnOrdenes);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnNegocios);
            this.Controls.Add(this.btnUsuarios);
            this.Name = "AdmiOpciones";
            this.Text = "AdmiOpciones";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnNegocios;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnOrdenes;
    }
}