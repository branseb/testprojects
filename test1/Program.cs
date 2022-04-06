using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meno = "Boris";
            //string je datový typ pre slová-retazec znakov ,slovo treba dať do úvodzoviek 
            var priezvisko = "Branse";
            //var je variabilny dátový typ ,pozor pri číslach vie robiť pičoviny 

            Console.WriteLine(meno +"\n"+ priezvisko);
            //writeline vypíše do riadku všetko v zátvorke ,\n-presunie na další riadok ,dalšie \ neguju a pridavaju do vypísania 
            Console.Read();
            //Read mi neuzatvorý príkazový riadok a čaka na moj príkaz 
        }
    }
}
