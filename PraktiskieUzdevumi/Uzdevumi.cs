using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskieUzdevumi
{
    class Uzdevumi
    {
        public static void Masivi()
        {
            int[] masivs = { 1, 10, 10, 2 };
            int[] jaunaisMasivs = new int[masivs.Length];


            int pozicija = 0;
            foreach(int skaitlis in masivs)
            {
                if( skaitlis != 10)
                {
                    jaunaisMasivs[pozicija] = skaitlis;
                    pozicija++;
                    Console.WriteLine(skaitlis);
                }
            }
        }
        public void CiparuSumma()
        {
            string skaitlis = "12321312";

            int summa = 0;
            foreach(char cipars in skaitlis)
            {
                int skaitlisCipars = Convert.ToInt32(cipars.ToString());
                summa += skaitlisCipars;
            }
            Console.WriteLine(summa);
        }
        public void Parole()
        {
            String ievaditaParole = "parole123123";

            int parolesGarums = ievaditaParole.Length;
            int lielieBurti = 0;
            int cipari = 0;

            foreach(char simbols in ievaditaParole)
            {
                if(simbols >= 'A' && simbols <= 'Z')
                {
                    lielieBurti++;
                    else if (simbols >= '0' && simbols <= '9')
                    {
                        cipari++;
                    }
                }
            }
            if(parolesGarums >= 10 && cipari >= 2 && lielieBurti >= 2)
            {
                { 
                    Console.WriteLine("parole ir deriga");
                

                }

               else
                {
                        Console.WriteLine("parole nav deriga");
                }
            }
        }
    }
}
