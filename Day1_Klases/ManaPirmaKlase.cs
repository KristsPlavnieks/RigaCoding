using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Klases
{
    public class ManaPirmaKlase

        //Funkcija bez rezultata un bez ievadparamentriem
    {
        public void SayHello() {
          Console.WriteLine("Hello");
        
            //Funkcija ar rezultat un bez ievadparametriem 
        }
        public int GetNumber() {
            return 99;
      

        }
        /// <summary>
        /// Funkcija ar rezultatu un ar ievadparametru
        /// </summary>
        /// <param name="skaitlis"></param>
        /// <returns></returns>
        public int GetNumber2(int skaitlis) {

            return skaitlis;
        }
    }
}
