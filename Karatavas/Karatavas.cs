using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    class Karatavas
    {
        List<string> vardi;

        string minamaisVards;

        char[] atminetaisVards;

        int dzivibas;

        public Karatavas()  // konstruktors

        {
            vardi = new List<string>()
            {
                "ABOLS",
                "BUMBIERIS",
                "ARBUZS",

            };
        }
        
        public void JaunaSpele()
        {
            dzivibas = 5;
            vardi = vardi.OrderBy(v => Guid.NewGuid()).ToList();    // sajaucam orderu
            minamaisVards = vardi[0];       // panem vienu vardu - 1 jeb 0to 
            atminetaisVards = new char[minamaisVards.Length];  // atminamajam vardam izveido masivu 
            for(int i = 0; i < minamaisVards.Length; i++)
            {
                atminetaisVards[i] = '_';   // atminetais vards i pozicija. 
            }

        }
        public bool Minet(char burts)
        {
            burts = Char.ToUpper(burts);
            bool vaiIrVarda = false;
            for(int i = 0; i < minamaisVards.Length; i++)
            {
                if (minamaisVards[i] == burts)  // parbauda vai atminetais burts ir varda 
                {
                    atminetaisVards[i] = burts;
                    vaiIrVarda = true;
                }
            }
            if (!vaiIrVarda) // ja neatmin burtu - 1 dziviba
            {
                dzivibas--;
            }

            return vaiIrVarda;

        }
        public int DzivibuSkaits()
        {
            return dzivibas;  // atgriez atlikusas dzivibas
        }

        public bool VaiIrAtminets()
        {
            // 1. risinajums - parbauda vai vards nav atminets
            return minamaisVards == new string(atminetaisVards);
            // 2. risinajums
           // return !atminetaisVards.Contains('_'); // parbauda vai vairak nav stripinu - jo atminets vards ir ja nav ! stripinu

        }

        public string AtminetaisVards()
        {
            // ___  -> _ _ _ _ 
            return String.Join(" ", atminetaisVards);  // apvieno simbolus 

        }
    }
}
