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
    public partial class PlayerUC : UserControl
    {
        public int PlayerNum { get; }

        public PlayerUC(int playerNum)
        {
            InitializeComponent();

            this.PlayerNum = playerNum;
        }

        public void RefreshData()
        {

        }
    }
}
