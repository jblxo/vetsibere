using System.Windows.Forms;

namespace vetsibere
{
    partial class PlayerUC : UserControl
    {
        private Player player;

        public PlayerUC(Player player)
        {
            InitializeComponent();

            this.player = player;
            this.LblPlayerName.Text = player.PlayerNum + "";
        }

        public void RefreshData()
        {
        }
    }
}
