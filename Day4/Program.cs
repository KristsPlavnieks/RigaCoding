using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Piemeri();
                                        
        }
        public static void Piemeri()
        {
            // i++ jeb i = i + 1
            // i sakotneja vertiba ir 40 
            //pildas tik ilgi kamer sasniedz 50 
            // katru reizi aug par 2 
            for (int i = 40; i <= 50; i = i + 2) // maninot i++ uz i = i + 2 nozime palielinasies par 2 
            {
                Console.WriteLine("i = " + i);
                
            }
            int n = 10;
            // pildit tik ilgi, kamer n ir lielaks vai vienads ar 0 
            while(n >= 0)
            {
                Console.WriteLine("n = " + n);
                n = n - 3;
            }



            bool turpinat = true;
            while(turpinat)
            {
                Console.Write("Ievadi skaitli: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Vai turpinas ievadit: (j/n)?");
                String atbilde = Console.ReadLine();

                if(atbilde == "j")
                {
                    turpinat = true;
                    
                }
                else
                {
                    turpinat = false;
                }

                uzdevumi uz = new uzdevumi();
                uz.Gadi();

                uzdevumi i = new uzdevumi();
                i.Skaitli();

                uzdevumi a = new uzdevumi();
                a.VelSkaitli();
            }
            Console.ReadLine();
        }
    }
}
