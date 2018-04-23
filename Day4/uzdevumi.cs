using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class uzdevumi
    {
        public void Gadi()
        {
            Console.WriteLine("ievadi gadu:");
            int gadsNo = Convert.ToInt32(Console.ReadLine());

            for (int gads = gadsNo; gads <= DateTime.Now.Year; gads++)
            {
                Console.WriteLine(gads + ".gads");
            }

        }
        public void Skaitli()
        {
            
        
            //1.paprasa ievadit skaitu N
            Console.Write("Ievadi skaitu: ");
            //2. nolasa ievadito vertibu 
            int n = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            //3.cikliski paprasa ievadit N vertibas
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Ievadi " + i + "skaitli ");
                //3.1 nolasa katru ievadito vertibu
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                summa = summa + skaitlis;// saisinajums : summa += skaitlis;
            }
                //4. aprekina ievadito skaitlu kopsumu
                Console.Write("Summa ir : " + summa);
                //5.aprekina ievadito skaitlu videjo vertibu 
                Console.Write("Videja vertiba: " + summa / n);
        }    
                   
           public void VelSkaitli()
        {
            Console.WriteLine("Ievadi skaitu:");
            int n = Convert.ToInt32(Console.ReadLine());
            // cikls, kas attelo N rindas
            for (int rinda = 1; rinda <=n; rinda++)
            {
               // cikls, kas attelo N rindas
                for(int kolona = 1; kolona <=n; kolona++)
                {
                    // cilks, kas izvada N simbolus jauna rinda 
                    Console.Write("#");
                }
                // parejam jauna rinda, kad ir izvadits N simboli
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
