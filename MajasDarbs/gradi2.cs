using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs
{
    class gradi2
    {
        public void GradiUzPretejo()
        {
            Console.WriteLine("Ievadiet gradus: ");
            int gradi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadiet mervienibu (F/C): ");
            string mervieniba = Console.ReadLine();
            // parversam uz lielajiem burtiem
            mervieniba = mervieniba.ToUpper();

            double rezultats;
            // ja lietotajs ievadija gradus pe F
            if(mervieniba == "F") // || mervieniba == "f")
            {
                rezultats = ((double)gradi - 32) * 5 / 9;
                Console.WriteLine(rezultats + "C");
            }
            // ja lietotajs ievada gradus pec c
            else if(mervieniba == "C") // else if no zime ja vienu augstak nosacijums nostrada sito nemaz neparbaudis 
            {
                rezultats = (double)gradi * 9 / 5 + 32;
                Console.WriteLine(rezultats + "F");
            }
            // visos citos gadijumos 
            else
            {
                Console.WriteLine("Ta ir nezinama mervieniba!");
            }
        }
    }
}
