using System;
using System.IO;
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

        private void NudPlyrCount_ValueChanged(object sender, EventArgs e)
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
