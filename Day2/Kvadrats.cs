using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Kvadrats
    {
        public string Krasa;
        public int MalasGarums;

        public Kvadrats()
        {

        }
        public Kvadrats(string krasa, int garums)
        {
            this.Krasa = krasa;
            this.MalasGarums = garums;
        }

        public void KrasasIzvade()
        {
            Console.WriteLine("Krasa ir " + this.Krasa);
          
        }
        public int Laukums()
        {
            return MalasGarums * MalasGarums;
        }
        public int Perimetrs()
        {
            return MalasGarums * 4;

        }


    }
}
