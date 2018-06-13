using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Classes
{   // parakstits no player panemot divas funkcijas
    class Dealer :   Player    // parnem visu kas ir otra klase! Mantosana -> ar :  Ar virtual var parakstit funkciju public virtual void utt. bet nav obligati japarraksta
    {   
        public override void GiveCard(Card card)  // ar OVERRID var parakstit un tad tik izveleties
        {
            Cards.Add(card);  // iedod karti nepazinojot kadu 
            
        }

        public void GiveCard(Card card, bool showCard)  // nosaukumi var sakrist, bet nosacijumi ne 
        {
            Cards.Add(card);
            if (showCard)
            {
                Console.WriteLine("Dileris sanema: " + card.Suit + card.Value);
            }
        }

        public override bool NeedAnotherCard()
        {
            return CountPoints() < 17;
        }
    }
}
