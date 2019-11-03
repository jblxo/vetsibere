using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            XmlSerializer reader =
                new XmlSerializer(typeof(XMLSettings));
            StreamReader file = new StreamReader(
                _pathToSettings);
            XMLSettings settings = (XMLSettings) reader.Deserialize(file);
            file.Close();

            GameData.Instance.PlayersCount = settings.PlayersCount;
            nudPlyrCount.Value = GameData.Instance.PlayersCount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPlayer(new PlayerSettingsUC());
        }

        void AddPlayer(PlayerSettingsUC p)
        {
            flowLayoutPanel1.Controls.Add(p);
            p.deleteMe += (deleteMeElement) =>
            {
                flowLayoutPanel1.Controls.Remove(deleteMeElement);
            };
        }

        public List<string> GetNames()
        {
            List<string> l = new List<string>();
            foreach (PlayerSettingsUC p in flowLayoutPanel1.Controls)
            {
                l.Add(p.PlayerName);
            }
            return l;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameData.Instance.PlayerNames = GetNames();

            XMLSettings settings = new XMLSettings
            {
                PlayerNames = GetNames().ToArray()
            };

            XmlSerializer writer = new XmlSerializer(typeof(XMLSettings));
            var path = _pathToSettings;
            FileStream file = File.Create(path);
            writer.Serialize(file, settings);
            file.Close();
        }
    }
}
