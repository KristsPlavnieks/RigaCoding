using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Classes
{
     class Player
    {
        public List<Card> Cards;            // deklaracija , bus manigais(karsu saraksts) ar sadu tipu.

        public Player()
        {
            Cards = new List<Card>();       // mainigaja kards- izveido jaunu tuksu sarakstu 
        }
        public virtual void  GiveCard(Card card)
        {
            Console.WriteLine("Speletajs sanema karti " + card.Suit + card.Value);
            Cards.Add(card);                // ievieto jauna speletaja roka karti
            Console.WriteLine("Punkti: " + CountPoints());
        }
        public int CountPoints()
        {
            int points = 0;
            int aceCount = 0;

            foreach(var c in Cards)
            {
                points += c.GetValue(); // parvers karti uz skaitlisku vertibu 
                if(c.Value == "A")
                {
                    aceCount++;
                }

            }

            while(points > 21 && aceCount > 0)
            {
                points -= 10;
                aceCount--;
            }


            return points;
        }
        public virtual bool NeedAnotherCard()
        {
            if(CountPoints() >= 21)
            {
                return false;
            }

            var answer = Game.GetAnswer("Vai ir nepieciesama karts");
            return answer;
                
        }
    }
}
