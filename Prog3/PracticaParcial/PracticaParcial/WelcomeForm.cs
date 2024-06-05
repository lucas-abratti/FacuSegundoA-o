using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParcial
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            WelcomeDelay.Interval = 1000;
            WelcomeDelay.Start();
            this.CenterToScreen();
        }

        private void WelcomeDelay_Tick(object sender, EventArgs e)
        {
            WelcomeDelay.Stop();
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
