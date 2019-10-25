using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetsibere
{
    class Factory
    {
        public Factory() { }
        public Card CreateCard(CardTypes type, int value)
        {
            Card card = new Card
            {
                Type = type,
                Value = value
            };
            return card;
        }
    }
}
