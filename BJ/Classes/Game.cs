using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Classes
{
    class Game
    { // speles logiku 
        public Dealer Dealer; // mainigie kas tiks izmantoti sini klase, pieejams visas funkcijas
        public Player Player;
        public Deck Deck;



        public bool StartNewGame()
        {   
            
            bool startNew = Game.GetAnswer("Vai uzsākt jaunu spēli");


            /*Console.WriteLine("Vai uzsākt jaunu spēli (jā/nē) ? ");
            string atbilde = Console.ReadLine().ToLower(); // parvers uzreiz uz mazajiem burtiem lai var nolasit atbildi
            bool startNew = atbilde == "ja"; // izveido jaunu manigo kas ir vienads ar atbildi un ja jā tad tas ir true 
            */
            if (startNew)
            {
                Console.WriteLine("Uzsākta jauna spēle!");
                Deck = Deck.TakeNewDeck();
                Dealer = new Dealer(); // ja ir kludas japarbauda vai visas klases ir publiskas
                Player = new Player();

                Deck.Shuffle(); // aiziet uz deku, panem shuffle funkciju 
                Player.GiveCard(Deck.TakeCard()); // iedos divreiz karti 
                Player.GiveCard(Deck.TakeCard());

                Dealer.GiveCard(Deck.TakeCard(), true);
                Dealer.GiveCard(Deck.TakeCard());

                while (Player.NeedAnotherCard()) // kamer vajadziga karts tikmer dod, lidz pasaka ne 
                {
                    Player.GiveCard(Deck.TakeCard());
                }

                while (Dealer.NeedAnotherCard())
                {
                     Dealer.GiveCard(Deck.TakeCard());
                }

                CountPoints();
            
            }
            return startNew;    // ja ne tad izies no cikla ara partraucot vsu speli 
        }

        public void CountPoints()
        {
            int playerPoints = Player.CountPoints();
            int dealerPoints = Dealer.CountPoints();

            if(playerPoints > 21)
            {
                Console.WriteLine("Tu zaudeji!");
            }
            else if (dealerPoints > 21)
            {
                Console.WriteLine("Tu uzvareji!");
            }

            else if (dealerPoints == playerPoints)
            {
                Console.WriteLine("Nav uzvaretaja!");
            }
            else if (playerPoints > dealerPoints)
            {
                Console.WriteLine("Tu uzvareji!");
            }
            else
            {
                Console.WriteLine("Tu zaudeji!");
            }
        }


        public static bool GetAnswer(string question) // tad ka bus jautajums var aizstat ar getanswer un nebus japaraksta visas linijas
        {
            Console.WriteLine(question + " (jā/nē) ? "); // var jebkura klase izsaukt jo ir public 
            string atbilde = Console.ReadLine().ToLower();
            bool answer = atbilde == "ja";

            return answer;


        }
    }
}
