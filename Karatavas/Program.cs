using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    class Program
    {
        static void Main(string[] args)
        {
            Karatavas karatavas = new Karatavas();   // <---- new Karatavas(); izveido jaunu objektu (konstruktors)
            karatavas.JaunaSpele();

            Console.WriteLine(karatavas.AtminetaisVards()); // izvadis svitrinas, lai zin cik burti jamin 

            while (!karatavas.VaiIrAtminets()&& karatavas.DzivibuSkaits() > 0)
            {
                Console.WriteLine("Ievadi burtu: ");
                char burts = Console.ReadLine()[0];   // panem pasu pirmo simbolu

                if (karatavas.Minet(burts))
                {
                    Console.WriteLine(karatavas.AtminetaisVards());
                }
                else
                {
                    Console.WriteLine("Burts " + burts + " nav varda!");
                    Console.WriteLine("Dzivibas: " + karatavas.DzivibuSkaits());
                }
            }

            if (karatavas.DzivibuSkaits() == 0)
            {
                Console.WriteLine("Beidzas dzivibas!");
            }
            else
            {
                Console.WriteLine("Vards ir atminets!");  // while cikls beidzas tikai tad, ka vards ir atminets.
            }
             
        }
    }
}
