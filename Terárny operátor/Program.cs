using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terárny_operátor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo1 = 1;
            int cislo2 = 2;

            bool rovnost = (cislo1 == cislo2);
            string vysledok = (rovnost) ? "áno" : "nie ";
            Console.WriteLine("je číslo " + cislo1 + " rovnaké ako číslo " + cislo2 + " ? " + vysledok);
            Console.Read();
        }
    }
}
