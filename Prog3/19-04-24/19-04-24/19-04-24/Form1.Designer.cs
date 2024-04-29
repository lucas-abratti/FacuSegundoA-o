namespace _19_04_24
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
            this.fraseLabel = new System.Windows.Forms.Label();
            this.fraseTextBox = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.readTextBox = new System.Windows.Forms.RichTextBox();
            this.resetFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fraseLabel
            // 
            this.fraseLabel.AutoSize = true;
            this.fraseLabel.Location = new System.Drawing.Point(354, 9);
            this.fraseLabel.Name = "fraseLabel";
            this.fraseLabel.Size = new System.Drawing.Size(33, 13);
            this.fraseLabel.TabIndex = 0;
            this.fraseLabel.Text = "Frase";
            // 
            // fraseTextBox
            // 
            this.fraseTextBox.Location = new System.Drawing.Point(321, 25);
            this.fraseTextBox.Name = "fraseTextBox";
            this.fraseTextBox.Size = new System.Drawing.Size(100, 20);
            this.fraseTextBox.TabIndex = 1;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(331, 51);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 2;
            this.registerBtn.Text = "Registrar";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(331, 91);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(75, 23);
            this.readBtn.TabIndex = 3;
            this.readBtn.Text = "Leer";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // readTextBox
            // 
            this.readTextBox.Location = new System.Drawing.Point(181, 120);
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.Size = new System.Drawing.Size(381, 223);
            this.readTextBox.TabIndex = 4;
            this.readTextBox.Text = "";
            // 
            // resetFile
            // 
            this.resetFile.Location = new System.Drawing.Point(657, 415);
            this.resetFile.Name = "resetFile";
            this.resetFile.Size = new System.Drawing.Size(131, 23);
            this.resetFile.TabIndex = 5;
            this.resetFile.Text = "Resetear Archivo";
            this.resetFile.UseVisualStyleBackColor = true;
            this.resetFile.Click += new System.EventHandler(this.resetFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetFile);
            this.Controls.Add(this.readTextBox);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.fraseTextBox);
            this.Controls.Add(this.fraseLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fraseLabel;
        private System.Windows.Forms.TextBox fraseTextBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.RichTextBox readTextBox;
        private System.Windows.Forms.Button resetFile;
    }
}

