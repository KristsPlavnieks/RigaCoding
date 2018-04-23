using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs
{
    class VecumaKalk
    {
        public void Vecums()
        {
            Console.Write("Ievadi savu vecumu : ");
            int TavsVecums = Convert.ToInt32(Console.ReadLine());
            if (TavsVecums > 18)
            {
                Console.WriteLine("Tu esi pilngadigs");
            }
            else
            {
                Console.WriteLine("Tu neesi pilngadigs");
            }

        }
               
                       
    }
}
