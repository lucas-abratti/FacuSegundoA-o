using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3Clase1
{
    public partial class Form1 : Form
    {
        string text;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text.Trim();
            if(txt.Text.Length == 0)
            {
                errorText.Text = "No se puede copiar un input vacio";
                MessageBox.Show("No se permite copiar un input vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorText.Text = "";
                text = txt.Text;
            }
        }
        private void btnPegar_Click(object sender, EventArgs e)
        {
            textLabel.Text = text;
            textLabel.Update();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            text = null;
            txt.Text = null;
            textLabel.Text = null;
            textLabel.Update();
            txt.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
