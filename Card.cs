using System.Drawing;
using System.Windows.Forms;

namespace vetsibere
{
    class Card
    {
        private Size _size = new Size(40, 120);
        public Point Position = new Point(0, 0);
        public int Value { get; set; } = -1;
        public string ImagePath { get; set; } = Application.StartupPath + "\\Images\\";

        public Card() { }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, new Rectangle(Position, _size));
        }
    }
}
