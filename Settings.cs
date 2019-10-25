using System.Windows.Forms;

namespace vetsibere
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void NudPlyrCount_ValueChanged(object sender, System.EventArgs e)
        {
            GameData.Instance.PlayersCount = (int) nudPlyrCount.Value;
        }
    }
}
