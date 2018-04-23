using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Auto
    {/// <summary>
    /// konstruktors norada - 
    /// nav rezultata tipa
    /// nosaukums sakrit ar klases nosaukumu 
    /// </summary>
        public Auto()
        {
            this.Marka = "nezinama";
            this.Krasa = "nezinama";
        }
        public string Marka;// auto marka 
        public string Krasa;// auto krasa
        public void Info()
        {
            
            Console.WriteLine("Auto marka ir:" + this.Marka); // this- sis mainigas nav jamekle funkcija, bet klase
            Console.WriteLine("Auto krasa ir:" + Krasa); // atrod ari bez, jo klase ir definets

        }
    }
}
