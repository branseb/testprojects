using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konvertovanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = "123a";
            string text2 = "456";

            //int cislo1 = Convert.ToInt32(text1);
            //toto konvertovanie vypíše chybovú hlášku lebo je v texte ktorý chcem konvertovať na číslo aj písmeno 
            int cislo1;
            int.TryParse(text1, out cislo1);
            //tryparse nepodarí sa konvertovať tak vypíše 0 a NEvypíše chybu
            int cislo2;
            bool konv = int.TryParse(text1, out cislo2);
            //bool napíse false ak sa nepodarí konvertovanie-čo je tento prípad
            //bla bla
            Console.WriteLine(cislo1 + "\n" + konv);
            Console.Read();

        }
    }
}
