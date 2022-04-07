using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatory_cykly
{
    internal class Cisla
    {
        public static string Getnumbername(string cislo)
        {

            if (cislo == "1")
            {
                return  "jeden";
            }
            else if (cislo == "2")
            {
                return ("dva");
            }
            else if (cislo == "3")
            {
                return ("tri");
            }
            else if (cislo == "4")
            {
                return ("štyri");
            }
            else if (cislo == "5")
            {
                return ("päť");
            }
            else if (cislo == "6")
            {
                return ("šesť");
            }
            else if (cislo == "7")
            {
                return ("sedem");
            }
            else if (cislo == "8")
            {
                return ("osem");
            }
            else if (cislo == "9")
            {
                return ("deväť");
            }
            else
            {
                return ("Neplatné číslo!!!");
            }
        }
    }
}
