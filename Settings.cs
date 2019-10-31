using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace vetsibere
{
    public partial class Settings : Form
    {
        private string _pathToSettings;

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
            StreamReader file = new System.IO.StreamReader(
                _pathToSettings);
            XMLSettings settings = (XMLSettings) reader.Deserialize(file);
            file.Close();

            GameData.Instance.PlayersCount = settings.PlayersCount;
            nudPlyrCount.Value = GameData.Instance.PlayersCount;
        }

        private void NudPlyrCount_ValueChanged(object sender, System.EventArgs e)
        {
            GameData.Instance.PlayersCount = (int) nudPlyrCount.Value;

            XMLSettings settings = new XMLSettings
            {
                PlayersCount = (int) nudPlyrCount.Value
            };

            XmlSerializer writer = new XmlSerializer(typeof(XMLSettings));
            var path = _pathToSettings;
            FileStream file = File.Create(path);
            writer.Serialize(file, settings);
            file.Close();
        }

        
    }
}
