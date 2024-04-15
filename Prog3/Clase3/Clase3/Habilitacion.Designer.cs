namespace Clase3
{
    partial class Habilitacion
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
            this.btnHabillitacion = new System.Windows.Forms.Button();
            this.inputDeshabilitable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHabillitacion
            // 
            this.btnHabillitacion.Location = new System.Drawing.Point(176, 97);
            this.btnHabillitacion.Name = "btnHabillitacion";
            this.btnHabillitacion.Size = new System.Drawing.Size(75, 23);
            this.btnHabillitacion.TabIndex = 0;
            this.btnHabillitacion.Text = "Deshabilitar";
            this.btnHabillitacion.UseVisualStyleBackColor = true;
            this.btnHabillitacion.Click += new System.EventHandler(this.btnHabillitacion_Click);
            // 
            // inputDeshabilitable
            // 
            this.inputDeshabilitable.Location = new System.Drawing.Point(162, 57);
            this.inputDeshabilitable.Name = "inputDeshabilitable";
            this.inputDeshabilitable.Size = new System.Drawing.Size(100, 20);
            this.inputDeshabilitable.TabIndex = 1;
            // 
            // Habilitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 174);
            this.Controls.Add(this.inputDeshabilitable);
            this.Controls.Add(this.btnHabillitacion);
            this.Name = "Habilitacion";
            this.Text = "Habilitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHabillitacion;
        private System.Windows.Forms.TextBox inputDeshabilitable;
    }
}