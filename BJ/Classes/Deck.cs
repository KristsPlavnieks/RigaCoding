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

        public Deck() // izsauc, ka nepieciesams jauns objekts no klases  // konstruktors ari ir funkcija, neko neatgriez , nav tipa pat ne void, nosaukums sakrit ar klases nosaukumu 
        {
            Cards = new List<Card>();

            foreach(char s in Suits) // iet cauri mastiem, un apstrada vertibas, uztaisis visas iespejamas vertibas no augsa suits un value
            {
                foreach(string v in Values) // cikls kas apstrada vertibas
                {
                    // pievieno karti karsu kavai 
                    Cards.Add(new Card(v, s));  
                }
            }
            


        }
        public Card TakeCard()
        {
            Card newCard = Cards[0]; // panem karti jaunu no kavas 
            
                Cards.RemoveAt(0);// panem izdzes 
                return newCard;  // atgriez, pasakot ka ta ir ta karts ko izdzesa
            
        }
        /// <summary>
        ///  Izveidot jaunu karsu kavu 
        /// </summary>
        /// <returns></returns>
        public static Deck TakeNewDeck()
        {
            return new Deck();
        }


        public void Shuffle() // funkcija sajaukt kavu 
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid()).ToList();// sakartot pec  random saraksta un salikt atpakal lista/ katru karti liek jauna mainigaja c 
        }
            
    }
}
