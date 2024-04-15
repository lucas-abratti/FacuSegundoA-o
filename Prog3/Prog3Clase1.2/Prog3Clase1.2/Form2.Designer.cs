namespace Prog3Clase1._2
{
    partial class Form2
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
            this.absCheck = new System.Windows.Forms.CheckBox();
            this.cierreCentralizadoCheck = new System.Windows.Forms.CheckBox();
            this.gpsCheck = new System.Windows.Forms.CheckBox();
            this.sedanRad = new System.Windows.Forms.RadioButton();
            this.hatchbackRad = new System.Windows.Forms.RadioButton();
            this.suvRad = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.propietarioText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // absCheck
            // 
            this.absCheck.AutoSize = true;
            this.absCheck.Location = new System.Drawing.Point(184, 177);
            this.absCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.absCheck.Name = "absCheck";
            this.absCheck.Size = new System.Drawing.Size(53, 20);
            this.absCheck.TabIndex = 1;
            this.absCheck.Text = "ABS";
            this.absCheck.UseVisualStyleBackColor = true;
            // 
            // cierreCentralizadoCheck
            // 
            this.cierreCentralizadoCheck.AutoSize = true;
            this.cierreCentralizadoCheck.Location = new System.Drawing.Point(338, 177);
            this.cierreCentralizadoCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cierreCentralizadoCheck.Name = "cierreCentralizadoCheck";
            this.cierreCentralizadoCheck.Size = new System.Drawing.Size(138, 20);
            this.cierreCentralizadoCheck.TabIndex = 2;
            this.cierreCentralizadoCheck.Text = "Cierre centralizado";
            this.cierreCentralizadoCheck.UseVisualStyleBackColor = true;
            // 
            // gpsCheck
            // 
            this.gpsCheck.AutoSize = true;
            this.gpsCheck.Location = new System.Drawing.Point(518, 177);
            this.gpsCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpsCheck.Name = "gpsCheck";
            this.gpsCheck.Size = new System.Drawing.Size(54, 20);
            this.gpsCheck.TabIndex = 3;
            this.gpsCheck.Text = "GPS";
            this.gpsCheck.UseVisualStyleBackColor = true;
            // 
            // sedanRad
            // 
            this.sedanRad.AutoSize = true;
            this.sedanRad.Location = new System.Drawing.Point(184, 242);
            this.sedanRad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sedanRad.Name = "sedanRad";
            this.sedanRad.Size = new System.Drawing.Size(65, 20);
            this.sedanRad.TabIndex = 4;
            this.sedanRad.TabStop = true;
            this.sedanRad.Text = "Sedan";
            this.sedanRad.UseVisualStyleBackColor = true;
            // 
            // hatchbackRad
            // 
            this.hatchbackRad.AutoSize = true;
            this.hatchbackRad.Location = new System.Drawing.Point(338, 242);
            this.hatchbackRad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hatchbackRad.Name = "hatchbackRad";
            this.hatchbackRad.Size = new System.Drawing.Size(90, 20);
            this.hatchbackRad.TabIndex = 5;
            this.hatchbackRad.TabStop = true;
            this.hatchbackRad.Text = "Hatchback";
            this.hatchbackRad.UseVisualStyleBackColor = true;
            // 
            // suvRad
            // 
            this.suvRad.AutoSize = true;
            this.suvRad.Location = new System.Drawing.Point(518, 242);
            this.suvRad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suvRad.Name = "suvRad";
            this.suvRad.Size = new System.Drawing.Size(53, 20);
            this.suvRad.TabIndex = 6;
            this.suvRad.TabStop = true;
            this.suvRad.Text = "SUV";
            this.suvRad.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(338, 96);
            this.marcaComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(160, 24);
            this.marcaComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marca";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(315, 376);
            this.resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(134, 33);
            this.resultado.TabIndex = 10;
            this.resultado.Text = "Selección";
            // 
            // propietarioText
            // 
            this.propietarioText.Location = new System.Drawing.Point(338, 26);
            this.propietarioText.Name = "propietarioText";
            this.propietarioText.Size = new System.Drawing.Size(160, 22);
            this.propietarioText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Proprietario";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.propietarioText);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marcaComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.suvRad);
            this.Controls.Add(this.hatchbackRad);
            this.Controls.Add(this.sedanRad);
            this.Controls.Add(this.gpsCheck);
            this.Controls.Add(this.cierreCentralizadoCheck);
            this.Controls.Add(this.absCheck);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox absCheck;
        private System.Windows.Forms.CheckBox cierreCentralizadoCheck;
        private System.Windows.Forms.CheckBox gpsCheck;
        private System.Windows.Forms.RadioButton sedanRad;
        private System.Windows.Forms.RadioButton hatchbackRad;
        private System.Windows.Forms.RadioButton suvRad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.TextBox propietarioText;
        private System.Windows.Forms.Label label2;
    }
}