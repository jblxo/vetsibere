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
        private readonly Size _size = new Size(40, 120);
        public Point Position = new Point(0, 0);
        public int Value { get; set; } = -1;
        public CardTypes Type { get; set; }
        public string ImagePath { get; set; } = Application.StartupPath + "\\Images\\";
        public int Owner { get; set; } = -1;
        public Card()
        {
            InitializeComponent();
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
