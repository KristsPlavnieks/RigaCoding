using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskaNodarbiba
{
    class UzdevumsViens
    {
        public void Dvirkne()
        {
            Console.Write("Ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            for (int skn = skaitlis; skn >= 1; skn--)
             
               
            {
                Console.WriteLine("" + skn);
            }
        }
        public void Modinatajs()
        {       // sakuma izskiro dienas , tad vai ir atval vai nav, un tad pieskir kam ko vajag. 
            Console.WriteLine("Diena: (P, O, T, C, Pk, Se, Sv)"); //Vnk -  "Ievadi dienu:"
            Console.WriteLine("Atvalinajums: (i, n)");
            string diena = Console.ReadLine();
            string atvalinajums = Console.ReadLine();
            diena = diena.ToUpper();

            if (diena == "P" || diena == "O" || diena == "T" || diena == "C" || diena == "PK") 
            {
                if (atvalinajums == "i")
                {
                    Console.WriteLine(diena + " ja " + " 10:00 ");
                }
                else
                {
                    Console.WriteLine(diena + " ne " + " 07:00 ");
                }
            }
            else if (diena == "SE" || diena == "SV")
            {
                if (atvalinajums == "i")      //|| atvalinajums == "n")

                {
                    Console.WriteLine("off ");
                }
                else
                {

                    Console.WriteLine("10:00");
                 // Console.WriteLine(iratvalinaums -- "ja" ? "off" : "10:00");  lidz ja ir if , pectam aiz off ja ne tad izpildas nakama. 
                }
                // else  .Console.WriteLine("Neatlauta veriba")
            } 
                    
                
        }
        public void Atrums()
        {
            Console.WriteLine("Atrums: ");
            int atrums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vai ir dzimsanas diena (ja/ne):");
            string irDzD = Console.ReadLine();
            // if(irDzD == "Ja"){
            // atrums = atrums -5; atrums -= 5; 
            if (irDzD == "Ja")
            {
                atrums -= 5;
            }

            if (atrums > 80)
            {
                Console.Write("leils sods " + " 2");
            }
            else if (atrums >= 61 && atrums <= 80)
            {
                Console.Write("ir neliels sods " + " 1");
            }
            else
            {
                Console.WriteLine("soda nav");
                                     
                                
            }
        }
        public void FizBuzz()
        {
            Console.WriteLine("ievadi skaitli1: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ievadi skaitli2: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            for (int i = sk1; i <= sk2; i++) // i ir viends ar sk1, pildas kamer sasniedz sk2, un pieskaita +1
            {
                if (i % 3 == 0 && i % 5 == 0) // && un  % vai sk dalas
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.Write(i);
                }
                 Console.Write(",");
                    
                
            }
        }
        public void Stop13()
        {
            int summa = 0; // mainigais kurs glabas summu 
            while(true) /// jo nezinam vertibu ko izvadis
            {
                Console.WriteLine("ievadit skaitli: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                if (skaitlis == 13)
                {
                    break; // partraukt ciklu // ja butu brak cilks cikla - tad vins strada tikai uz ieksejo ciklu  // return partrauc funkciju un izvada ara 
                }
                else
                {  // var iztikt bez Else dalas, jo ir  break 
                    summa += skaitlis;
                }
            }
            
            Console.WriteLine("Summa ir " + summa);
        }
    }
}
