using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_04_24
{
    public partial class frmEjercicio5 : Form
    {
        public frmEjercicio5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fechaNacimientoPicker.MaxDate = DateTime.Today;
            dniTextBox.MaxLength = 8;
            nombreTextBox.MaxLength = 30;
            apellidoTextBox.MaxLength = 30;
            cantidadHijosTextoBox.MaxLength = 2;
            estadoCivilComboBox.Items.Add("Casado");
            estadoCivilComboBox.Items.Add("Soltero");
            estadoCivilComboBox.Items.Add("Viudo");
            estadoCivilComboBox.Items.Add("Casado con la solteria");

            lista.View = View.Details;
            lista.Columns.Add("DNI");
            lista.Columns.Add("Apellido");
            lista.Columns.Add("Nombre");
            lista.Columns.Add("Cantidad hijos");
            lista.Columns.Add("Estado civil");
            lista.Columns.Add("Fecha de nacimiento");
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {

            if (dniTextBox.Text.Trim().Length < 8)
            {
                MessageBox.Show("DNI no puede tener menos de 8 caracteres");
                return;
            }

            int dni;
            if (!int.TryParse(dniTextBox.Text.Trim(), out dni))
            {
                MessageBox.Show("DNI tiene que ser un numero valido");
                return;
            }
            else if (dni <= 0)
            {
                MessageBox.Show("DNI tiene que ser un numero mayor a 0");
                return;

            }
            for (int i = 0; i < lista.Items.Count; i++)
            {
                int currentNum;
                if (int.TryParse(lista.Items[i].Text, out currentNum))
                {
                    if (currentNum == dni)
                    {
                        MessageBox.Show("DNI tiene q ser unico");
                        return;
                    }
                }
            }

            string apellido = apellidoTextBox.Text.Trim();
            if (apellido.Length == 0)
            {
                MessageBox.Show("Apellido no puede ser nulo");
                return;
            }

            string nombre = nombreTextBox.Text.Trim();
            if (nombre.Length == 0)
            {
                MessageBox.Show("Nombre no puede ser nulo");
                return;
            }

            int cantHijos;
            if (!int.TryParse(cantidadHijosTextoBox.Text.Trim(), out cantHijos))
            {
                MessageBox.Show("Cantidad de hijos tiene q ser un numero valido");
                return;
            }
            else if(cantHijos < 0)
            {
                MessageBox.Show("Cantidad de hijos tiene q ser mayor o igual a 0");
                return;
            }

            if (estadoCivilComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado civil");
                return;
            }

            int currentItem = lista.Items.Count;

            lista.Items.Add(dni.ToString());
            lista.Items[currentItem].SubItems.Add(nombre);
            lista.Items[currentItem].SubItems.Add(apellido);
            lista.Items[currentItem].SubItems.Add(cantHijos.ToString());
            lista.Items[currentItem].SubItems.Add(estadoCivilComboBox.SelectedItem.ToString());
            lista.Items[currentItem].SubItems.Add(fechaNacimientoPicker.Text);

            dniTextBox.Text = "";
            apellidoTextBox.Text = "";
            nombreTextBox.Text = "";
            cantidadHijosTextoBox.Text = "";
            estadoCivilComboBox.SelectedItem = null;
            fechaNacimientoPicker.Value = DateTime.Today;
        }
    }
}
