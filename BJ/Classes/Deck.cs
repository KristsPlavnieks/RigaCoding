using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Classes
{
    class Deck
    {    // masti : Hearts, Diamonds, Spades, Clubs
        public char[] Suits = { 'H', 'D', 'S', 'C' };
        // vertibas no 2 -A
        public string[] Values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };




        /// <summary>
        /// kartis
        /// </summary>
        public List<Card> Cards;

        public Deck()
        {
            Cards = new List<Card>();

            foreach(char s in Suits)
            {
                foreach(string v in Values) // cikls kas apstrada vertibas
                {
                    Cards.Add(new Card(v, s)); 
                }
            }
            


        }
        public Card TakeCard()
        {
            Card newCard = Cards[0]; // panem karti jaunu no kavas 
            {
                Cards.RemoveAt(0);// panem izdzes atgriez 
                return newCard; 
            }
        }
        /// <summary>
        ///  Izveidot jaunu karsu kavu 
        /// </summary>
        /// <returns></returns>
        public Deck TakeNewDeck()
        {
            return null;
        }
        public void Shuffle()
        {

        }
            
    }
}
