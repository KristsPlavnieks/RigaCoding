using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs
{
    class TrisSkaitli
    {
        public void Skaitli()
        {
            Console.Write("Ievadi pirmo skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi treso skaitli: ");
            int skaitlis3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skaitlu videja summa ir : " + (double)(skaitlis1 + skaitlis2 + skaitlis3) / 3);
            
              
            


        }
    }
}
