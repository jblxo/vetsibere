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
            this.LblPlayerName.Text = player.Name;
            RefreshData();
        }

        public void RefreshData()
        {
            this.lblCardsLeft.Text = player.Cards.Count.ToString();
        }
    }
}
