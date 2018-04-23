using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {       /// <summary>
            ///Galvenais ieejas punkts aplikacija 
            /// </summary>
            /// <param name="args"></param>
        static void Main(string[] args)
        {   // izveido jaunu objektu no klases uzdevumi
            Uzdevumi uzdevumi = new Uzdevumi(); // pirmais tips, otrais mainiga nosaukums 

            //izsauc objekta funkcijas
            /* uzdevumi.Starpiba(123, 52); 
             uzdevumi.Reizinajums(2, 3, 4);
             uzdevumi.SkaitluMaina(5, 6);
             uzdevumi.Aprekini(1, 2);
             uzdevumi.IevadiVardu();
             uzdevumi.IevadiGradusC();
             */
            
           /* Auto auto = new Auto();
            auto.Krasa = "Melns";
            auto.Marka = "Audi";
            auto.Info();

            Auto vw = new Auto();
            vw.Krasa = "zila";
            vw.Marka = "VW";
            vw.Info();

            Auto nezinams = new Auto();
            nezinams.Info(); 
            */

            Kvadrats kv1 = new Kvadrats();
            kv1.Krasa = "sarkana";
            kv1.MalasGarums = 4;
            kv1.KrasasIzvade();
            int laukums = kv1.Laukums();
            Console.WriteLine("Laukums ir " + laukums);
            Console.WriteLine("Perimetrs ir " + kv1.Perimetrs());

            Kvadrats kv2 = new Kvadrats("melns", 5);
            kv2.KrasasIzvade();
            Console.WriteLine("Perimetrs ir " + kv2.Perimetrs());

            Uzdevumi gradi = new Uzdevumi();
            gradi.IevadiGradusC();

            //funkcija, kas patur atveru logu
            //lidz nospiez enter
            Console.ReadLine();
        }
    }
}
