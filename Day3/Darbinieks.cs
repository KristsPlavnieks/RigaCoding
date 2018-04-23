using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Darbinieks
    {
        public string Vards;
        public string Uzvards;
        public int Dzgads;
        public string epasts;
        public string talrunis;
        public Adrese Dzivesvieta;
        public Nodala AktualaNodala;
        public Nodala IeprieksejaNodala;
    
        public void TeikumsViens()
        {
            Console.WriteLine(" Mani sauc " + Vards + ", es dzivoju" + Dzivesvieta.PilnaAdrese());
        }
        public void TeikumsDivi()

        {
            Console.WriteLine(" Mani sauc " + Vards + " un es pargaju uz " + AktualaNodala.Nosaukums + " no " + IeprieksejaNodala.Nosaukums + " kura atradas " + IeprieksejaNodala.AtrasanaVieta.PilnaAdrese());
            
        }
    }
}
