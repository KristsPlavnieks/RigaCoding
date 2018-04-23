using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Sazarojumi
{
    class uzdevumi
    {
        public void VienadiSkaitli()
        {
            Console.Write("Ievadi pirmo skaitli ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi otru skaitli ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());
            if (skaitlis1 == skaitlis2)
            {
                Console.WriteLine("skaitlis ir vienadi");
            }

            else
            {



                Console.WriteLine("Skaitli nav vienadi");


            }
        }
            public void Menesis()
            {
            Console.WriteLine("Ievadi menesi: ");
            string menesis = Console.ReadLine();
            if (menesis == "Feb")
            {
                Console.WriteLine(" 28 dienas ");
            }

            else if (menesis == "Apr" || menesis == "Jun" || menesis == "Sep") ;
                }
            
            
            
                
              
            }

            
        }
        
    }
}
