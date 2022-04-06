using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podmienky
{
    internal class Program
    {
        static void Main(string[] args)
        {   //porovnáv
            int cis1 = 1;                   //zadefinovanie cis1 a cis2 
            int cis2 = 2;
            bool pravda =(2 == 2);          //porovnaie čísel 2 a 2  - pre porovnanie treba 2x = {pre definovanie je to iba 1x}
            bool cis1vscis2 =(cis1 == cis2);//porovnanie cis1 a cis2 -čísla niesu rovné -výsledok nepravda
            bool zaroven = (cis1 == 1 && cis2 == 2);//&& znamená a zároveň -výsledok je true iba ak obydve podmienky sú true{pravdivé}
            bool alebo = (cis1 == 8 || cis2 == 2);// || znamená alebo - jedna podmienka musí byť true aby bol aj vysledok true
                                                  // znaky | je skratka ALT gr + W

            Console.WriteLine(" 2 = 2 ? " + pravda);//vypíše true -pravda
            
            Console.WriteLine(cis1 + " = " + cis2 + " ? " + cis1vscis2); // vypíše false - nepravda
            
            Console.WriteLine("je číslo " + cis1 + " a číslo 1 a zároveň aj číslo " + cis2 + " a číslo 2 rovnaké ? " + zaroven); //výsledok je true -pravda

            Console.WriteLine("je číslo " + cis1 + " a číslo 1  alebo číslo " + cis2 + " a číslo 2 rovnaké ? " + alebo);
                

            //!negácia

            int cis3 = 3;
            int cis4 = 4;
            bool nepravda =(cis3 != cis4); //čisla niesú rovnaké tak výsledok je pravda

            Console.WriteLine("sú čísla " + cis3 + " a " + cis4 + " rozdielne ? " + nepravda);

            
            
            Console.Read();
        }
    }
}
