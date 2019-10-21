using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vetsibere.Properties;

namespace vetsibere
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            SwitchForms(new Game());
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Větší karta bere. Nuda.");
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SwitchForms(new Settings());
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SwitchForms(Form form)
        {
            form.Show();
            form.FormClosed += (sender, args) => Show();
            Hide();
        }
    }
}
