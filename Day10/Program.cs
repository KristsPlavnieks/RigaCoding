using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Program
    {   public static void Funkcija(int skaitlis2) // atgriezis neko, nekadu vertibu  (   ) ievadparametri
        {
            int skaitlis = 5;
            Console.WriteLine(skaitlis * skaitlis2);
        }


        static void Main(string[] args)

        {
            Console.WriteLine("Ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            Funkcija(skaitlis);      // mainigos ko define funkcijas ietvaros, darbojas tikai funkcijas ietvaros. Nosaukumi var but vienadi vairakas funkcijas. 

            int[] masivs = { 5, 10, 25, 4, 1 };

            foreach(int skaitlis  in masivs)
            {
                                
                for(int i = 1; i <= skaitlis; i++)
                {
                  Console.WriteLine(skaitlis);   // cikls izpildisies 5 reizes, nostradas 1 reizi. iterejam

                }
            }
            // masivs ar netikai vienu ipasibu, javeido masivs ar objektiem.  izveidojam jaunu clasi 
            Prece[] preces = new Prece[3];
            List<Prece> precesList = new List<Prece>();

            preces[0] = new Prece() {Cena = 5, Nosaukums = "Prece1" };    // aizpilda masivu 
            preces[1] = new Prece() {Cena = 25, Nosaukums = "Prece2" };
            preces[2] = new Prece() {Cena = 35, Nosaukums = "Prece3" };

            precesList.Add(new Prece() { Cena = 5, Nosaukums = "Prece1" }); // aizpilda listu 



        }
    }
}
