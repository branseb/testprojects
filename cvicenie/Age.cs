using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie
{
    internal class Age
    {
        public static int Calculate(int cislo1, int cislo2)
        {
            int max = Math.Max(cislo1, cislo2);
            int min = Math.Min(cislo1, cislo2);
            int vysledok = max - 2 * min;
            return vysledok;


        }

    }
}
