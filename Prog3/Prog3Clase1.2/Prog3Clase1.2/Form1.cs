using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3Clase1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            rbNativo.Checked = true;
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = txtApellido.Text.Trim();
            if(txtApellido.Text != null && txtApellido.Text != "")
            {
                MessageBox.Show($"Usted ah cargado el siguiente usuario: \nApellido: {txtApellido.Text}\nAdulto: {chkAdulto.Checked}\nNativo: {rbNativo.Checked}\nExtranjero: {rbExtranjero.Checked}","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Apellido vacio", "Incompleto", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
