using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Classes
{
    class Card
    {
        /// <summary>
        /// Vertiba
        /// </summary>
        public string Value;

        /// <summary>
        /// masts
        /// </summary>
        public char Suit;
        /// <summary>
        /// izveido jaunu karti
        /// </summary>
        /// <param name="value"></param>
        /// <param name="suit"></param>

        public Card(string value, char suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
        /// <summary>
        /// Karts skaitliska vertiba
        /// </summary>
        /// <returns></returns>
        public int GetValue()
        {
            return 0;
        }
    }
}
