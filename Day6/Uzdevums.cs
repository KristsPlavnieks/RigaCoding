using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Uzdevums
    {
        
        public static void UzdViens() // static - navstavokla nevar pieklut objekta ipasibam // izmanto ja ta ir paligfunkcija
        {
            Console.WriteLine("Ievadi skaitu N: ");
            int n = Convert.ToInt32(Console.ReadLine());
                // no 1 lidz rindas nr 
            for (int rinda = 1; rinda <= n; rinda++) 
            {   // izvada sk rinda no 1 lidz rindas kartas numuram
                for (int kolona = 1; kolona <= rinda; kolona++)   
                  //  for (int kolona = skaitlis - rinda; kolona >= 1; kolona --)  tas butu otradak
                {
                    Console.Write(kolona);
                }
                Console.WriteLine();
            }
        }
        public static void ApgrieztsMasivs()
        {
            Console.WriteLine("Cik skaitlus noradis: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] skaitli = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Ievadi " + (i+1) + ".skaitli"); // salabot ka saksies no 1 nevis 0 (i+1)
                skaitli[i] = Convert.ToInt32(Console.ReadLine());
                //pozicija [] <- i, jo tas ir no 0 lidz n 
            }
            for (int i = N - 1; i >= 0; i--) // preteja seciba||  no N- skaitlu masiva (respektivi -1 jo sakas no 0 , tad lidz 0 . 
            {
                Console.WriteLine(skaitli[i]);
            }
        }
        public static void UzdDiv()
        {
            int[] skaitluMasivs = { 
                0, 10, 20, 30, 40, 50  
            };

            Console.WriteLine("Ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < skaitluMasivs.Length; i++)
            {
                if (skaitluMasivs[i] == skaitlis)
                {
                    Console.WriteLine("Skaitlis ir atrasts!");
                    Console.WriteLine("Pozicija = " + i);
                    // atrodot skaitli izies gan no cikla gan pareja. 
                    return;           //break; // partrauc ciklu bet kas ir aiz tapat vnmr izpildisies
                }
            }
            Console.WriteLine("Skaitlis nav atrasts!");

            // tas butu jaraksta cikla vieta - sakot no for lidz console

            int pozicija = Array.IndexOf(skaitluMasivs, skaitlis); // ja elementu neatrod atgriez -1
            if ( pozicija == -1)
            {
                Console.WriteLine("skaitlis nav atrasts!");
            }
        }  
    }
}
