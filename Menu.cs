using System;
using System.Windows.Forms;

namespace vetsibere
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            FormClosed += Menu_FormClosed;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            Application.Exit();
        }

        /// <summary>
        /// Closes menu form. Opens form specified in parameter. Wires up function which opens the menu after the param form is closed.
        /// </summary>
        /// <param name="form">Form to be displayed</param>
        private void SwitchForms(Form form)
        {
            form.Show();
            form.FormClosed += (sender, args) => Show();
            Hide();
        }
    }
}
