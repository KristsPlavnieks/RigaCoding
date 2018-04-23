using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskaDivi
{
    class Uzdevumi
    {
        public static void UzdevumsViens()
        {
            Console.Write("Ievadi skaitli1 : ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi skaitli2 : ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            int[] skaitluMasivs = new int[2];


            skaitluMasivs[0] = sk1;
            skaitluMasivs[1] = sk2;

            foreach (int skaitlis in skaitluMasivs) 
            {
                Console.WriteLine("Skaitlu summa : " + (sk1 + sk2));
                Console.WriteLine("Skaitlu starpiba : " + (sk1 - sk2));
                Console.WriteLine("Skaitlu reizinajums : " + (sk1 * sk2));
                if( sk1 > sk2)
                {
                    Console.WriteLine("Lielakais skaitlis : " + sk1);
                    Console.WriteLine("Mazakais skaitlis : " + sk2);
                }
                else
                {
                    Console.WriteLine("Lielakais skaitlis : " + sk2);
                    Console.WriteLine("Mazakais skaitlis : " + sk1);
                }
                break;
                
            }
            Console.WriteLine("Videja vertiba : " + (double)(sk1 + sk2) / 2);
        }

        public static void UzdevumsDivi()
        {
            
        }
    }
}
