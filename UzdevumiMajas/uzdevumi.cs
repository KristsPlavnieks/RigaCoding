using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumiMajas
{
    class uzdevumi
    {
        public void Gradi()
        {
            Console.Write("ievadi parametrus: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadit F - ja velaties tempF C - ja velaties tempC: ");

            string atbilde = Console.ReadLine();
            atbilde = atbilde.ToUpper();

            double rezultats;
            if (atbilde == "F") 
            {
                rezultats = ((double)skaitlis - 32) * 5 / 9;
                Console.WriteLine(rezultats + "F");
            }
            else if (atbilde == "C")
            {
                rezultats = (double)skaitlis * 9 / 5 + 32;
                Console.WriteLine(rezultats + "C");
            }
        }
        public void intervals()
        {
            Console.Write("ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            if (skaitlis >= - 50) 
            {
                if (skaitlis <= 50)
                {
                    Console.WriteLine("Skaitlis ir intervala");
                }
                else
                {
                    Console.WriteLine("skaitlis nav intervala");
                }
                
            }
                        
        }
        public void ParaSkaitli()
        {
            Console.Write("Ievadiet skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            if(skaitlis %2 == 0)
            {
                Console.WriteLine("Skaitlis ir para: ");
            }
            else
            {
                Console.WriteLine("Skaitlis nav para: ");
            }
        }
        public void MazLel()
        {
            Console.WriteLine("ievadi pirmo skaitli: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ievadi otro skaitli: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ievadi treso skaitli: ");
            int sk3 = Convert.ToInt32(Console.ReadLine());

            if (sk1 > sk2)

            {
                if(sk1 > sk3)
                {
                    Console.WriteLine("Skaitlis viens ir lielakais:");
                }
                else
                {
                    Console.WriteLine("Skaitlis tris ir lielakais");
                }
                
                    
            }
            else if(sk2 > sk3)
            {
                Console.WriteLine("Skaitlis divi ir lielakais: ");
            }
            else
            {
                Console.WriteLine("Skaitlis tris ir lielakais: "); 
            }
        }
    }
}
