using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Uzdevumi
    {
        public static void Skaitlis()
        {
            Console.WriteLine("Ievadi skaitlus: ");
            int skaits = Convert.ToInt32(Console.ReadLine());

            int[] masivs = new int[skaits];  // izveido skaitlu masivu 

            // cikls, kas aizpilda masivu ar skaitliem
            for (int i = 0; i < skaits; i++)
            {
                Console.WriteLine("Ievadiet skaitli: ");
                masivs[i] = Convert.ToInt32(Console.ReadLine()); // ievieto masiva ievadito skaitli
            }
            // cikls, kas atrod skaitlus 5 masiva
            // for(int = 0; i < masivs.Lenght; i++) garais pieraksts

            foreach (int skaitlis in masivs)
            {
                int skaititajs = 0;
                if (skaitlis == 5)

                {
                    skaititajs++;
                }

                Console.WriteLine("Atrasti " + skaititajs + " skaitli 5"); // pazino cik skaitli atrasti
            }



        }
        public static void Valsts()
        {
            Console.Write("Ievadi valsti:");
            string valsts = Console.ReadLine();

            switch (valsts.ToLower())
            {
                case "igaunija":
                    Console.WriteLine("Tallina");
                    break;
                case "somija":
                    Console.WriteLine("Helsinki");
                    break;
                case "ukraina":
                    Console.WriteLine("Kijeva");
                    break;
                case "zviedrija":
                    Console.WriteLine("Stokholma");
                    break;
                case "krievija":
                    Console.WriteLine("Maskava");
                    break;
                default:
                    Console.WriteLine("Galvaspilseta nav zinama!");
                    break;
            }
        }
        public static void Uzdevums()
        {
            try
            {
                Console.Write("Ievadi skaitli1: ");
                int sk1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ievadi skaitli2: ");
                int sk2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ievadi veicamo operaciju:");
                string op = (Console.ReadLine());

                double rezultats; // mainigais prieks rezultta
                rezultats = (double)sk1 + sk2;
                switch (op)
                {
                    case "+":
                        rezultats = sk1 + sk2;
                        break;
                    case "-":
                        rezultats = sk1 - sk2;
                        break;
                    case "/":
                        rezultats = sk1 / sk2;

                        if (sk2 == 0)  // ja ievada nuli 
                        {
                            Console.WriteLine("Darbiba nav atlauta!");
                            return;
                        }
                        break;
                    case "*":
                        rezultats = sk1 * sk2;
                        break;
                    default:
                        Console.WriteLine("neatlauta darbiba");
                        Uzdevums();  // lai atgriezas sakuma ja ir veicis neatlautu darbibu 
                        return;
                }
                Console.WriteLine("rezultats = " + rezultats);
            }
            catch (Exception)  // nolasa kludas, un atgriez uz augsu 
            {
                Console.Write("Neatbilstosa vertiba");
                Uzdevums();
            }
        }
        public static void LielMaz()
        {
            Console.WriteLine("Ievadi cik skaitli: ");
            int skaits = Convert.ToInt32(Console.ReadLine());
            
            int[] masivs = new int[skaits];
                        
            for (int i = 0; i < skaits; i++)
            {

                Console.WriteLine("Ievadiet skaitli: ");
                masivs[i] = Convert.ToInt32(Console.ReadLine());
            }
                int min = masivs[0];               // 1.nosaka ka pirma vertiba ir mazaka
                int max = masivs[0];

                // pasaka ka izies cauri visiem masivs elementiem 
                foreach (int skaitlis in masivs) // 2.iziet cauri visam vertibam , ar ciklu vins iet uz apli kamer atrod 
            {
                if(skaitlis < min)
                {
                    min = skaitlis;
                }
                else if(skaitlis > max)
                {
                    max = skaitlis;
                }
            }
            Console.WriteLine("min = " + min);
            Console.WriteLine("max = " + max);

            // otrs variants
            int minimums = masivs.Min();
            int maksimums = masivs.Max();
        }   
     }
}

