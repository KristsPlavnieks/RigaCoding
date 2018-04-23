using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Taisnsturis t1 = new Taisnsturis(3, 54);
            Taisnsturis t2 = new Taisnsturis(32, 54);
            t1.Laukums();
            t2.Laukums();
            */


            Darbinieks darb = new Darbinieks();
            darb.Vards = "Peteris";
            darb.Dzivesvieta = new Adrese();
            darb.Dzivesvieta.Valsts = " Latvija ";
            darb.Dzivesvieta.Pilseta = "Riga";
            darb.Dzivesvieta.Iela = "Rupniecibas iela 12";
            darb.Dzivesvieta.DzivoklaNr = 405;

            darb.AktualaNodala = new Nodala();
            darb.AktualaNodala.Nosaukums = "fffff";
            darb.AktualaNodala.AtrasanaVieta = new Adrese();
            


            darb.IeprieksejaNodala = new Nodala();
            darb.IeprieksejaNodala.Nosaukums = "yyyyy";
            darb.IeprieksejaNodala.AtrasanaVieta = new Adrese();
            


           





            darb.TeikumsViens();
            darb.TeikumsDivi();



        
            Console.ReadLine();

        }
    }
}
