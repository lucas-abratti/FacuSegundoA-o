using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string input = userInput.Text.Trim();

            if (comboBox1.Items.Contains(input))
            {
                return;
            }
            else
            {
                MessageBox.Show("Las opciones deben ser unicas");
            }

            if (input.Length > 5 && input.Length < 15)
            {
                comboBox1.Items.Add(input);
            }
            else
            {
                MessageBox.Show("Las opciones deben tener entre 5 y 15 caracteres");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
