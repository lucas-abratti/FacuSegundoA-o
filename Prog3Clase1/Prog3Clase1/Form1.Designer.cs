using System;

namespace Prog3Clase1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnPegar = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.Borrar = new System.Windows.Forms.Button();
            this.errorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(277, 153);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(189, 20);
            this.txt.TabIndex = 0;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(340, 193);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 1;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnPegar
            // 
            this.btnPegar.Location = new System.Drawing.Point(340, 235);
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(75, 23);
            this.btnPegar.TabIndex = 2;
            this.btnPegar.Text = "Pegar";
            this.btnPegar.UseVisualStyleBackColor = true;
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(369, 121);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(0, 13);
            this.textLabel.TabIndex = 3;
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(340, 273);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 4;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // errorText
            // 
            this.errorText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorText.AutoSize = true;
            this.errorText.BackColor = System.Drawing.SystemColors.Control;
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Name = "errorText";
            this.errorText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.btnPegar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnPegar;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Label errorText;
    }
}

