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
    public partial class Card : UserControl
    {
        public CardNames CardName { get; set; }
        public CardTypes Type { get; set; }
        public string ImagePath { get; set; } = Application.StartupPath + "\\Images\\";
        public Player Owner { get; set; }
        public Card(CardTypes type, CardNames name)
        {
            Type = type;
            CardName = name;

            InitializeComponent();

            lblName.Text = Type + " " + CardName;
            lblValue.Text = (int) CardName + "";

            Bitmap cardImage = (Bitmap) Properties.Resources.ResourceManager.GetObject($"_{(int) name}_{(int) type}");
            pbImage.Image = cardImage;
        }

        public void DisplayOwnerName()
        {
            lblOwner.Text = Owner.Name;
        }
    }

    public enum CardTypes
    {
        Kule = 1,
        Srdce = 2,
        Listy = 3,
        Zaludy = 4
    }

    public enum CardNames
    {
        Sedm = 7,
        Osm = 8,
        Devet = 9,
        Deset = 10,
        Spodek = 2,
        Svrsek = 3,
        Kral = 4,
        Eso = 12
    }
}
