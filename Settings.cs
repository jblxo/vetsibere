using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace vetsibere
{
    public partial class Settings : Form
    {
        private readonly string _pathToSettings;

        public Settings()
        {
            _pathToSettings = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                              "//Settings.xml";

            InitializeComponent();

            LoadSettings();
        }

        private void LoadSettings()
        {
            XmlSerializer reader =
                new XmlSerializer(typeof(XMLSettings));

            GameData.Instance.PlayerNames = settings.PlayerNames.ToList();

            foreach (string s in GameData.Instance.PlayerNames)
            {
                AddPlayer(new PlayerSettingsUC(s));
            }
        }

        public static void LoadSettingsFromXML()
        {
            if (File.Exists(_pathToSettings))
            {
                StreamReader file = new StreamReader(
                    _pathToSettings);
                XMLSettings settings = (XMLSettings)reader.Deserialize(file);
                file.Close();

                GameData.Instance.PlayersCount = settings.PlayersCount;
                nudPlyrCount.Value = GameData.Instance.PlayersCount;
                GameData.Instance.PlayerNames = settings.PlayerNames.ToList();
            }
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
