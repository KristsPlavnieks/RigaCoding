using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Uzdevumi
    {/// <summary>
     /// starpiba starp skaitlis1 un skaitlis2
     /// </summary>
     /// <param name="skaitlis1"></param>
     /// <param name="skaitlis2"></param>
        public void Starpiba(int skaitlis1, int skaitlis2)
        {


            int starpiba = skaitlis1 - skaitlis2;
            Console.WriteLine(starpiba);




        }
        public void Reizinajums(int skaitlis3, int skaitlis4, int skaitlis5)
        {
            long reizinajums = skaitlis3 * skaitlis4 * skaitlis5;
            Console.WriteLine(reizinajums);
        }
        public void SkaitluMaina(int sk1, int sk2)
        {
            Console.WriteLine("sk1 = " + sk1);//5
            Console.WriteLine("sk2 = " + sk2);//6

            //apstrade
            int sk1VecaVertiba = sk1;
            sk1 = sk2;
            sk2 = sk1VecaVertiba;

            Console.WriteLine("sk1 = " + sk1);//6
            Console.WriteLine("sk2 = " + sk2);//5


        }
        public void Aprekini(int sk1, int sk2)
        { 
            Console.WriteLine(sk1 + sk2);// skaitlu summa
            Console.WriteLine(sk1 - sk2);// skaitlu starpiba
            Console.WriteLine(sk1 * sk2);//skaitlu reizinajum
            Console.WriteLine((double)sk1 / sk2);// skaitlu dalijums 
            Console.WriteLine(sk1 % sk2); // dalisanas atlikums, panak ar - % 
        }   /// <summary>
        /// definejam jaunu funkciju
        /// kas nesanem parametrus 
        /// un kas neatgriez jaunu/vertibu
        /// </summary>
        public void IevadiVardu()
        {
            // izvada tekstu un kursos paliek tani pasa rindina
            Console.Write("Ievadi vardu:");
            // nolasa ievadito textu
            string vards = Console.ReadLine();
            // texta izvade, un kursors pariet jauna rinda
            Console.WriteLine("Tevi sauc:" + vards);
            Console.Write("Ievadi skaitli:");
            // parveido ievadito textu uz veselu skaitli
            int skaitlis = Convert.ToInt32( Console.ReadLine()); // var ari rakstit atseviski string skaitlisTekstuals = Consule.ReadLne(); int skaitlis = Convert.ToInt32(skaitlisTekstuals);
            // izvada rezultatu
            Console.WriteLine("Skaitlis ir:" + skaitlis);
        }
        public void IevadiGradusC()
        {
            Console.Write("Ievadi gradus pec Celsija:");
            int gradi = Convert.ToInt32(Console.ReadLine());
            double gradiF = gradi * 9 / 5 + 32;
            double gradiK = gradi + 273;
            Console.WriteLine("Pec Farenheina:" + gradiF);
            Console.WriteLine("Pec Kelvina:" + gradiK);
        }








    }  

}
