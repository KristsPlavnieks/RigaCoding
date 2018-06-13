using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumiMajasDivi
{
    class Uzdevumi
    {
        public static void ParaSkaitli()
        {
            Console.Write("Ievadi skaitli: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi otru skaitli: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            int i = sk1;
            int min = Math.Min(sk1, sk2);
            int max = Math.Max(sk1, sk2);

            for(i = min; i <= max; i++)
            {
              if( i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine();
            }
        }

        public static void UzminiSkaitli()
        {
            List<int> skaitluSaraksts = new List<int>()
            {
                2, 16, 8, 15, 14, 3, 10, 7, 4
            };
            skaitluSaraksts = skaitluSaraksts.OrderBy(n => Guid.NewGuid()).ToList();
            int skaitlis = skaitluSaraksts[0];

            bool minejums = false;


            while(!minejums)
            {
                try
                {
                    Console.WriteLine("Uzmini skaitli ... ");
                    int ievaditaisSkaitlis = Convert.ToInt32(Console.ReadLine());

                    if(ievaditaisSkaitlis == skaitlis)
                    {
                        Console.WriteLine("Uzminēji !!");
                        minejums = true;
                    }
                    else if (ievaditaisSkaitlis > skaitlis)
                    {
                        Console.WriteLine("Minējums ir pārāk augsts!");
                    }
                    else if ( ievaditaisSkaitlis < skaitlis)
                    {
                        Console.WriteLine("Minējums ir pārāk zems!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nesapratu! ");
                    UzminiSkaitli();
                }
            }
        }

        public static void Veikals()
        {

            List<string> Preces = new List<string>() { "Lg", "Nokia", "Iphone", "Huawei", "Samsung", "Pixel", };

            List<int> Cenas = new List<int>() { 300, 260, 650, 730, 560, 840 };


        }

        
        /*   i = 1; atst = 2 = 3 - 1; zv = 1 = 2 * 2 - 1;
         *   i = 2; atst = 1 = 3 - 2; zv = 3 = 2 * 2 - 1;
         *   i = 3; atst = 0 = 3 - 3; zv = 5 = 2 * 3 - 1;
         */ 
                   

        public static void Dimants()
        {
            int N = 10;                          // rindu skaits
            for (int i = 1; i <= N; i ++)       // cikls, kas strada pa rindam un tiek lidz vidum
            {
                for (int atst = 1; atst <= N - i; atst ++ ) // cikls, kurs sazimes atstarpes
                {
                    Console.Write(" ");       // izvadam atstarpi
                                                   
                }
                for(int zv = 1; zv <= 2 * i - 1; zv++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                                                   
            }
                                    
            for (int i = N - 1; i >= 1; i--)       // tads pats cikls, tikai preteji
            {
                for (int atst = 1; atst <= N - i; atst++) // cikls, kurs sazimes atstarpes
                {
                    Console.Write(" ");       // izvadam atstarpi

                }
                for (int zv = 1; zv <= 2 * i - 1; zv++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();



            }
        }
    }
}
