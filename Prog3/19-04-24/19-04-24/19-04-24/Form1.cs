using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_04_24
{
    public partial class Form1 : Form
    {
        private string stringPath = "./archivo.txt";
        string[] content = new string[0];
        public Form1()
        {
            InitializeComponent();
            updateContent();
        }

        private void updateContent()
        {
            FileStream fs = new FileStream(stringPath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            content = new string[0];
            int i = 0;
            while (!sr.EndOfStream)
            {
                content = new string[content.Length + 1];
                content[i] = sr.ReadLine();
                i++;
            }
            sr.Close();
            fs.Close();
        }

        private bool compararCOnTodasLasLineas(string value)
        {
            FileStream fs = new FileStream(stringPath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            int i = 0;
            while (!sr.EndOfStream)
            {
                i++;
                if (sr.ReadLine() != value)
                {
                    continue;
                }
                else
                {
                    sr.Close();
                    fs.Close();
                    return false;
                }
            }
            sr.Close();
            fs.Close();
            return true;
        }

        private void writeStringToFile(string frase)
        {

            FileStream fs = new FileStream(stringPath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(frase);

            sw.Close();
            fs.Close();

            updateContent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string frase = fraseTextBox.Text.Trim();
            //if(compararCOnTodasLasLineas(frase))
            if (!content.Contains(frase))
            {
                writeStringToFile(frase);
            }
            else
            {
                MessageBox.Show("LINEA REPETIDA");
            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(stringPath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadToEnd();
            readTextBox.Text = content;

            sr.Close();
            fs.Close();
        }

        private void resetFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(stringPath, FileMode.Create);
            fs.Close();
            updateContent();
        }
    }
}
