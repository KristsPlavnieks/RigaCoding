using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs
{
    class Gradi

    {
        public static double CtempUzF(string tempc)
        {
            // Converte argumentu uz double prieks aprekina
            double c = System.Double.Parse(tempc);
            // converte c uz f
            double f = (c * 9 / 5) + 32;

            return f;
        }

        public static double FtempUzC(string tempf)
        {
            double F = System.Double.Parse(tempf);
            double C = (F - 32) * 5 / 9;

            return C;
        }



    }
}

   