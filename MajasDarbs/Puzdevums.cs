using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs
{
    class Puzdevums
    {
        public void VaiIrPara()
        {
            Console.WriteLine("Ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            

            if (skaitlis % 2 == 0)
            {
                Console.WriteLine("Ir para skaitlis");
            }
            else
            {
                Console.WriteLine("Nav para skaitlis");
            }
        }
    }
}
