namespace Prog3Clase1._2
{
    partial class Presentacion
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
            this.components = new System.ComponentModel.Container();
            this.Enter = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(119, 359);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 0;
            this.Enter.Text = "ENTER";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(606, 359);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "CLOSE";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(267, 93);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(247, 39);
            this.logo.TabIndex = 3;
            this.logo.Text = "BienAhíInc";
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.logo);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Enter);
            this.Name = "Presentacion";
            this.Text = "Presentacion";
            this.Load += new System.EventHandler(this.Presentacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Timer timer1;
    }
}