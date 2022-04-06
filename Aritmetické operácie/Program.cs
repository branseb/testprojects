using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetické_operácie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo1 = 5; //int može byť iba celé čislo 
            double cislo2 = 2;//double je vačší dátový typ ako int ,može byť aj desatinné 
            double vysledok = cislo1 / cislo2;//pre zobrazenie desatiného čisla músi
                                              //byť dátový typ s desatinnym miestom 
                                              //a taktiež musí byt dátový typ v ktorom
                                              //je aritmetická operácia s des. miestom 
                                              //v tomto prípade je to double
                                              //tu výpíše na riadok 2.5

            Console.WriteLine(vysledok);

            int cislo3 = 12;
            int cislo4 = 5;
            Console.WriteLine((double) cislo3 / cislo4);//v tomto zápise sa zobrazí výsledok v dátovom 
                                                        //double -aj desatinné miesto


            //modulo % -"zvyšok po delení"

            int cislo5 = 11;                    
            int cislo6 = 3;
            Console.WriteLine("modulo-% " + cislo5 % cislo6); //modulo je zvysok po deleni celeho čísla celým číslo 
                                                //v tomto prípade sa 3 zmestí do 11 3 krát a zvyšok je 2
                                                //zobrazí sa 2 

            // */%  -súrovnocenné operátory a majú prednosť pred +-

            Console.WriteLine("bez zátvorky" +( 1 + 2 * 3 / 4.0));//najskôr sa násobí a delí ,potom +1 , výsledok je 2.5
            
            Console.WriteLine("zo zátvorkou" + (1 + 2) * 3 / 4.0);//zátvorka má prednosť
            Console.Write("\n");
            //prefix {číslo sa vypíse a zvýši sa}

            Console.WriteLine("prefix:");
            int cislo7 = 1;
            Console.WriteLine(cislo7++);//vypíše sa číslo7 a zvýši sa 
            Console.WriteLine(cislo7); //vypíše sa číslo7 ktoré je zvýšené predchádzajúcim príkazom takže
                                       //sa vypíše 2 neni ++ tak sa nezvýši

            Console.WriteLine(cislo7++);//vypíše sa 2 a zvýši sa 
            Console.WriteLine(cislo7++);//vypíše sa a zvýši
            Console.WriteLine(cislo7++);//vypíše sa a zvýši
            Console.WriteLine(cislo7);//vypíše sa zvýsene z predchádzajúceho kroku 


            //refix {číslo sa zvýši a vypíše}
            Console.WriteLine("\n" + "refix"); 
            int cislo8 = 1;
            Console.WriteLine(cislo8);//číslo sa vypíše
            Console.WriteLine(++cislo8);//číslo sa najskôr výši a potom sa vypíše :2
            Console.WriteLine(++cislo8);//zvýši sa a vypíše 
            Console.WriteLine(++cislo8);//zvýši sa a vypíše
            Console.WriteLine(cislo8);//vypíše sa

            //delenie nulou
            Console.WriteLine("\ndelenie nulou");
            //Console.WriteLine(5 / 0);   //nespustí program vypíše chybu
            // Console.WriteLine(5 / 0.0);   //vypíše ? {nekonečno}
            Console.WriteLine(0 / 0.0);     //vypíše NaN {žiadne číslo}


            Console.Read();
        }
    }
}
