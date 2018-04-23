using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs
{
    class Program
    {
        static void Main(string[] args)
        {
            gradi2 gradi = new gradi2();
            gradi.GradiUzPretejo();
            
            VecumaKalk kalk = new VecumaKalk();
            kalk.Vecums();

            TrisSkaitli skaitli = new TrisSkaitli();
            skaitli.Skaitli();


            Console.ReadLine();

            
            Console.Write("Ievadi convertacijas veidu:");
            Console.Write("1.No C uz F: ");
            Console.Write("2.No F uz C: ");

            string izvele = Console.ReadLine(); 
            double C, F = 0;
            switch (izvele)
            { 
                case "1": 
                    Console.Write("Ievadi tempC: ");
                    F = Gradi.CtempUzF(Console.ReadLine());
                    Console.WriteLine("TempF: {0:F2}", F);
                    break;

                case "2":
                    Console.Write("Ievadi tempF: ");
                    C = Gradi.FtempUzC(Console.ReadLine());
                   Console.WriteLine("TempC: {0:F2}", C);
                    break;

                default:
                    Console.WriteLine("Ludzu izvelies convertoru");
                    break;


                    
                    

            }
                    Console.ReadLine();
        }

    }
}
