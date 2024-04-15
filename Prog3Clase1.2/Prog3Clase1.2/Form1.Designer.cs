namespace Prog3Clase1._2
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.chkAdulto = new System.Windows.Forms.CheckBox();
            this.rbNativo = new System.Windows.Forms.RadioButton();
            this.rbExtranjero = new System.Windows.Forms.RadioButton();
            this.Registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(315, 64);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 0;
            // 
            // chkAdulto
            // 
            this.chkAdulto.AutoSize = true;
            this.chkAdulto.Location = new System.Drawing.Point(315, 103);
            this.chkAdulto.Name = "chkAdulto";
            this.chkAdulto.Size = new System.Drawing.Size(56, 17);
            this.chkAdulto.TabIndex = 1;
            this.chkAdulto.Text = "Adulto";
            this.chkAdulto.UseVisualStyleBackColor = true;
            // 
            // rbNativo
            // 
            this.rbNativo.AutoSize = true;
            this.rbNativo.Location = new System.Drawing.Point(315, 126);
            this.rbNativo.Name = "rbNativo";
            this.rbNativo.Size = new System.Drawing.Size(56, 17);
            this.rbNativo.TabIndex = 2;
            this.rbNativo.TabStop = true;
            this.rbNativo.Text = "Nativo";
            this.rbNativo.UseVisualStyleBackColor = true;
            // 
            // rbExtranjero
            // 
            this.rbExtranjero.AutoSize = true;
            this.rbExtranjero.Location = new System.Drawing.Point(315, 149);
            this.rbExtranjero.Name = "rbExtranjero";
            this.rbExtranjero.Size = new System.Drawing.Size(72, 17);
            this.rbExtranjero.TabIndex = 3;
            this.rbExtranjero.TabStop = true;
            this.rbExtranjero.Text = "Extranjero";
            this.rbExtranjero.UseVisualStyleBackColor = true;
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(315, 256);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 4;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.rbExtranjero);
            this.Controls.Add(this.rbNativo);
            this.Controls.Add(this.chkAdulto);
            this.Controls.Add(this.txtApellido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.CheckBox chkAdulto;
        private System.Windows.Forms.RadioButton rbNativo;
        private System.Windows.Forms.RadioButton rbExtranjero;
        private System.Windows.Forms.Button Registrar;
    }
}

