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
            switch (Value)
            {
                case "A":   // ari var ar if, witch stradas atrak.
                    return 11;
                case "J":
                case "Q":
                case "K":
                    return 10;
                default:   // atgriezisies pie cipara vertibas. atgriezot skaitli
                    return Convert.ToInt32(Value); // viss beidzas funkcija.  Break izbeidz funkciju bet nepamet cilku liek ka ir cikls vai switch 
                

            }

        }
    }
}
