using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Taisnsturis
    {
        public int Mala1;

        public int Mala2;

        public Taisnsturis(int mala1, int mala2)
        {
            Mala1 = mala1;
            Mala2 = mala2;
        }
        public void Laukums()
        {
            int laukums = Mala1 * Mala2;
            Console.WriteLine("Laukums ir " + laukums);
        }

    }
}
