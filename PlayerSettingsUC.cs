using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vetsibere
{
    public partial class PlayerSettingsUC : UserControl
    {
        public event Action<PlayerSettingsUC> deleteMe;

        public static string[] playerNames = new string[] { "Matěj", "Ondra", "David","Jessie", "Walter","Jim", "Yeet"};
        public static Random r = new Random();
        public string PlayerName => textBox1.Text;

        public PlayerSettingsUC()
        {
            InitializeComponent();
            textBox1.Text = playerNames[r.Next(0,playerNames.Length)];
        }

        public PlayerSettingsUC(string name)
        {
            InitializeComponent();
            textBox1.Text = name;
        }

        private void x_Click(object sender, EventArgs e)
        {
            deleteMe?.Invoke(this);
        }
    }
}
