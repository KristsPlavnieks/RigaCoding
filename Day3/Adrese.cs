using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Adrese
    {
        public string Valsts;
        public string Pilseta;
        public string Iela;
        public int MajasNr;
        public int DzivoklaNr;
        public string PilnaAdrese()
        {
            string adrese = Valsts + "," + Pilseta + "," + Iela + "," + MajasNr + "," + DzivoklaNr;
            return adrese;

        }
        
    }

    
}
