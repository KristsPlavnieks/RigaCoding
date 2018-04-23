using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Classes
{
    class Game
    { // speles logiku 
        public Dealer Dealer;
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
                Deck = new Deck();
                Dealer = new Dealer(); // ja ir kludas japarbauda vai visas klases ir publiskas
                Player = new Player();
            }
            return startNew;    // ja ne tad izies no cikla ara partraucot vsu speli 
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
