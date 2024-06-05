using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParcial
{
    public partial class PaymentsList : Form
    {
        string currentValues = "";
        public PaymentsList()
        {
            InitializeComponent();
        }

        private void PaymentsList_Load(object sender, EventArgs e)
        {
            CenterToParent();
            namesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            namesComboBox.Items.Add("Lucas Abratti");
            namesComboBox.Items.Add("Ignacio Cordero");
            namesComboBox.Items.Add("Tadeo Cardelli");
            namesComboBox.Items.Add("Julia Gaeto");
            namesComboBox.Items.Add("Ignacio Menna");
            namesComboBox.Items.Add("Fausto Pulido");

            paymentsListVew.Columns.Add("Legajo");
            paymentsListVew.Columns.Add("ApelNom");
            paymentsListVew.Columns.Add("Fecha");
            paymentsListVew.Columns.Add("Hs. Trab.");
            paymentsListVew.Columns.Add("Importe");

            paymentsListVew.View = View.Details;

            Filter("");
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);

                sw.Write(currentValues);

                sw.Close();
                fs.Close();
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            Filter(namesComboBox.Text);
        }

        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            namesComboBox.Enabled = !allCheckBox.Checked;

            if (allCheckBox.Checked)
            {
                Filter("");
            }
            else
            {
                Filter(namesComboBox.Text);
            }
        }

        private void Filter(string name)
        {
            currentValues = "";
            numberOfPayments.Text = 0.ToString();

            FileStream fs = new FileStream("Pagos.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            paymentsListVew.Items.Clear();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                string [] data = line.Split(';');

                if (name != "" && data[1] != name) { continue; }
                
                currentValues += line + "\n";

                numberOfPayments.Text = (int.Parse(numberOfPayments.Text) + 1).ToString();

                ListViewItem item = new ListViewItem(data[0]);

                paymentsListVew.Items.Add(item);
                paymentsListVew.Items[paymentsListVew.Items.Count - 1].SubItems.Add(data[1]);
                paymentsListVew.Items[paymentsListVew.Items.Count - 1].SubItems.Add(data[2]);
                paymentsListVew.Items[paymentsListVew.Items.Count - 1].SubItems.Add(data[3]);
                paymentsListVew.Items[paymentsListVew.Items.Count - 1].SubItems.Add(data[4]);
            }

            sr.Close();
            fs.Close();
        }
    }
}
