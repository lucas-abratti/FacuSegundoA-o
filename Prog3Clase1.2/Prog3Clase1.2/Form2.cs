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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            sedanRad.Checked = true;
            marcaComboBox.Items.Add("Ford");
            marcaComboBox.Items.Add("Fiat");
            marcaComboBox.Items.Add("Ferrari");
            marcaComboBox.Items.Add("Peugot");
            marcaComboBox.Items.Add("Honda");
            marcaComboBox.Items.Add("Nissan");
            marcaComboBox.Items.Add("Toyota");
            marcaComboBox.Items.Add("Tesla");

            marcaComboBox.SelectedIndex = 0;
            marcaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";

            if (propietarioText.Text.Length > 15 || propietarioText.Text.Length < 8)
            {
                MessageBox.Show("El nombre del propietario tiene que tener un minimo de 8 caracteres y un maximo de 15");
                return;
            }
            else
            {
                result += $"{propietarioText.Text} quiere ";
            }

            result += $"un {marcaComboBox.Text} que sea:\n";

            if (sedanRad.Checked)
            {
                result += "Un sedan\n";
            }
            else if (hatchbackRad.Checked)
            {
                result += "Un hatchback\n";
            }
            else if (suvRad.Checked)
            {
                result += "Un SUV\n";
            }
            else
            {
                MessageBox.Show("Necesita seleccionar un tipo de chasis para el vehiculo");
                return;
            }
            //
            if (absCheck.Checked)
            {
                result += "Con ABS\n";
            }
            else
            {
                result += "Sin ABS\n";
            }
            if (cierreCentralizadoCheck.Checked)
            {
                result += "Con cierre centralizado\n";
            }
            else
            {
                result += "Sin cierre centralizado\n";
            }
            if (gpsCheck.Checked)
            {
                result += "Con GPS\n";
            }
            else
            {
                result += "Sin GPS\n";
            }

            resultado.Text = result;
        }

    }
}
