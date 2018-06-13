using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        /// <summary>
        /// ar trim parasti komente klases
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //teksta izvade konsole
            Console.WriteLine("Hello World!");
            Console.WriteLine(5); //ja grib izvadit skaitli -  neliek pedinas
            Console.WriteLine(4.6); // ja grib decimalu - atdala ar punktu 
            Console.WriteLine("T"); // simbola izvade
            Console.WriteLine('T'); // uztver ka simbolu(var ierakstit tikai vienu simbolu, atstarpe cipars utt.)

            int skaitlis1 = 9223;
            // norada kads bus skaits - int tips- vesels nevar ar atstarpem, var ar lielo burtu vai ciparu ka - Skaitlis1, SkaitlisViens
            Console.WriteLine(skaitlis1); // izsauc mainigo 
            Console.WriteLine("Skaitlis1"); // kodu lasa no augsas uz leju 

            SayHello(); // funkcijas izsaukums

            Console.ReadLine();
            /*komentars
             vairakas
             rindas
             */
            
        }
        //funkcija bez rezultata (void tips)
        public static void SayHello() // funkcijas definejums
        {
            Console.WriteLine("Hello!");
        }
            public static void OutputNumber()
        {
            Console.WriteLine(5);
        }

     

    }
}
