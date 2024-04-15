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
    public partial class Habilitacion : Form
    {
        public Habilitacion()
        {
            InitializeComponent();
        }

        private void btnHabillitacion_Click(object sender, EventArgs e)
        {
            Habilitacion hab = new Habilitacion();
            hab.Show();
            if (inputDeshabilitable.Enabled)
            {
                inputDeshabilitable.Enabled = false;
                btnHabillitacion.Text = "Habilitar";
            }
            else
            {
                inputDeshabilitable.Enabled = true;
                btnHabillitacion.Text = "Deshabilitar";
            }
        }
    }
}
