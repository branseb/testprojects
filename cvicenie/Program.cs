using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date.Now();
            while (true)
            {
                Console.WriteLine("zadaj prvy vek");

                var vek1 = Console.ReadLine();
                Console.WriteLine("zadaj druhy vek");
                var vek2 = Console.ReadLine();
                int cislo1 = Convert.ToInt32(vek1);
                int cislo2 = Convert.ToInt32(vek2);

                int vysledok = Age.Calculate(cislo1, cislo2);
                Console.WriteLine(vysledok);
            }
            
            Console.ReadLine();



            /*Console.WriteLine("ahoj");
            Console.WriteLine("Zadaj prvy vek");
            string vek1 = Console.ReadLine();
            Console.WriteLine("Zadaj druhy vek");
            string vek2 = Console.ReadLine();
            int cislo1 = Convert.ToInt32(vek1);
            int cislo2 = Convert.ToInt32(vek2);
           int vysleok = Age.Calculate(cislo1, cislo2);

            Console.WriteLine(vysleok);


            Console.ReadLine();
            */




        }
    }
}