namespace PracticaParcial
{
    partial class PaymentsList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.namesComboBox = new System.Windows.Forms.ComboBox();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.paymentsListVew = new System.Windows.Forms.ListView();
            this.numberOfPayments = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.namesComboBox);
            this.groupBox1.Controls.Add(this.allCheckBox);
            this.groupBox1.Controls.Add(this.filterBtn);
            this.groupBox1.Controls.Add(this.exportBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // namesComboBox
            // 
            this.namesComboBox.FormattingEnabled = true;
            this.namesComboBox.Location = new System.Drawing.Point(6, 42);
            this.namesComboBox.Name = "namesComboBox";
            this.namesComboBox.Size = new System.Drawing.Size(275, 21);
            this.namesComboBox.TabIndex = 1;
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.Location = new System.Drawing.Point(6, 19);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(56, 17);
            this.allCheckBox.TabIndex = 1;
            this.allCheckBox.Text = "Todos";
            this.allCheckBox.UseVisualStyleBackColor = true;
            this.allCheckBox.CheckedChanged += new System.EventHandler(this.allCheckBox_CheckedChanged);
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(582, 21);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(91, 61);
            this.filterBtn.TabIndex = 1;
            this.filterBtn.Text = "Filtrar";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(679, 21);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(91, 61);
            this.exportBtn.TabIndex = 0;
            this.exportBtn.Text = "Exportar";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // paymentsListVew
            // 
            this.paymentsListVew.HideSelection = false;
            this.paymentsListVew.Location = new System.Drawing.Point(12, 120);
            this.paymentsListVew.Name = "paymentsListVew";
            this.paymentsListVew.Size = new System.Drawing.Size(776, 305);
            this.paymentsListVew.TabIndex = 2;
            this.paymentsListVew.UseCompatibleStateImageBehavior = false;
            // 
            // numberOfPayments
            // 
            this.numberOfPayments.AutoSize = true;
            this.numberOfPayments.Location = new System.Drawing.Point(715, 428);
            this.numberOfPayments.Name = "numberOfPayments";
            this.numberOfPayments.Size = new System.Drawing.Size(13, 13);
            this.numberOfPayments.TabIndex = 3;
            this.numberOfPayments.Text = "0";
            // 
            // PaymentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberOfPayments);
            this.Controls.Add(this.paymentsListVew);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaymentsList";
            this.Text = "PaymentsList";
            this.Load += new System.EventHandler(this.PaymentsList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox namesComboBox;
        private System.Windows.Forms.CheckBox allCheckBox;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.ListView paymentsListVew;
        private System.Windows.Forms.Label numberOfPayments;
    }
}