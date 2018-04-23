using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Klases
{
    class Program
    {
        static void Main(string[] args)
        {   //1.Maniga tips = ManaPirmaKlase
            //2.mainiga nosaukums = objekts
            //3.sakotneja vertiba = jauns objekts no sis klases
            /*ManaPirmaKlase objekts = new ManaPirmaKlase(); // izveidojam objektu no musu definetas klases, lai izsauktu klasi vajag objektu 
            objekts.SayHello(); // punkts pa vidu-izsaukt objektu 
            objekts.SayHello();
            int rezultats = objekts.GetNumber();
            Console.WriteLine(rezultats);


            int rezultats2 = objekts.GetNumber2(100);
            Console.WriteLine(rezultats2);*/

            uzdevumi uzdevumi = new uzdevumi(); // var izmantot ar - var - indikatoru 
        
            uzdevumi.Uzdevums1("Krists");

            uzdevumi.Uzdevums2(142, 23);

            
            Console.ReadLine();
            
        }
    }
}
