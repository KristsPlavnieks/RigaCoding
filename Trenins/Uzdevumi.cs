using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trenins
{
    class Uzdevumi
    {
        public static void UzdevumsViens()
        {
            Console.Write("Ievadi skaitli1 : ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi skaitli2 : ");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            

            

            Console.WriteLine("Skaitlu summa : " + (sk1 + sk2));
            Console.WriteLine("Skaitlu starpiba : " + (sk1 - sk2));
            Console.WriteLine("Skaitlu reizinajums : " + (sk1 * sk2));

            if (sk1 > sk2)
            {
                Console.WriteLine("Lielakais skaitlis : " + sk1);
                Console.WriteLine("Mazakais skaitlis : " + sk2);
            }
            else
            {
                Console.WriteLine("Lielakais skaitlis : " + sk2);
                Console.WriteLine("Mazakais skaitlis : " + sk1);
            }
           Console.WriteLine("Videja vertiba : " + (double)(sk1 + sk2) / 2);

            
        }

        public static void UzdevumsDivi()
        {
            int[] skaitluMasivs =
            {
                1, 10, 10, 2, 2, 10, 15
            };
            

            for(int i = 0; i < skaitluMasivs.Length; i++)
            {
                if(skaitluMasivs[i] != 10)
                {
                    Console.WriteLine(skaitluMasivs[i]);
                }
            }
        }

        public static void UzdevumsTris()
        {
            Console.Write("Ievadi skaitli: ");
            int sk = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= sk; i++) // loops ieks loopa - 1.loops lai noteiktu lidz cik skaitis 
            {
                for(int a = 1; a <= i; a++) // 2. loops reali skaita ciparus
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine(",");
            }
        }
        public static void UzdevumsKaratavas()
        {
            string[] vardi =
            {
                "aka",
                "laka",
                "suns",
                "kakis",
                "zakis",
            };
                Random r = new Random();


            List<string> vardu = new List<string>();
            {
               
                

                
                  

                
            
            }

           


        }
    }
}
