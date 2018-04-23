using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uzdevumi.Skaitlis();
            // Uzdevumi.Valsts();
            Uzdevumi.Uzdevums();

            Console.ReadLine();
        }

        public static void Piemers()
        {
            Console.Write("Ievadi dienu: ");
            string diena = Console.ReadLine();

            switch (diena) // no mainiga diena
            {
                case "P": // izmanto ja ir daudz if var ari but if 
                case "O":
                case "T":
                case "C":
                case "Pk":
                    Console.WriteLine("Ir darbadiena");
                    if(diena == "Pk")
                    {
                        Console.WriteLine("Piektdiena");
                    }
                                            
                    break; // ja nav - pildas tik talu kamer iziet caur visam

                case "Se":
                case "Sv":
                    Console.WriteLine("Ir brivdiena");
                    break;

                default:
                    Console.WriteLine("Nezinama diena");
                    break;
                    
                  
            }

        }
    }
}
