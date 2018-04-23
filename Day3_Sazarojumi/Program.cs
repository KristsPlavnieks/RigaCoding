using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Sazarojumi
{
    class Program
    {
        static void Main(string[] args)
        {
            uzdevumi skaitli = new uzdevumi();
            skaitli.VienadiSkaitli();

            Console.ReadLine();

                
            }
        public void Piemers()
        {
            int skaitlis = 99;

            bool vaiIrVienadsArPieci = skaitlis == 5;

            if (skaitlis > 5)
            {
                Console.WriteLine("skaitlis ir lielaks par 5");
            }
            else if (skaitlis == 5)
            {
                Console.WriteLine("skaitlis ir vienads ar 5");
            }
            else
            {
                Console.WriteLine("skaitlis nav lielaks par 5 ");
            }
        }
                
                    
                
                       
                    
                
            
        
    }
}
