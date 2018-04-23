using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs
{
    class Intervals
    {

        public void Skaitli()
        {   //ievada skaitli
            Console.WriteLine("Ievadi skaitli: ");
            // nolasa ievadito skaitli
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            if (skaitlis >= -50)

            {
                if (skaitlis <= 50)
                {
                    Console.WriteLine("Skaitlis ir atbilstosaja intervala");
                }
                else
                {
                    Console.WriteLine("Skaitlis nav atbilstosaja intervala");

                }
                // 2.varinats
                if (skaitlis >= -50)
                {
                    if (skaitlis <= 50)
                    {
                        Console.WriteLine("Skaitlis ir atbilstosaja intervala");
                        // return partrauc funcijas talako izpildi
                        return;
                    }
                }
                Console.WriteLine("Skaitlis nav atbilstosaja intervala");


                //3.varinats
                if (skaitlis >= -50 && skaitlis <= 50)
                {
                    Console.WriteLine("Skaitlis ir atbilstosaja intervala");
                }
                else
                {
                    Console.WriteLine("Skaitlis nav atbilstosaja intervala");

                }


                
            }
            
           
        }

    }
}   
