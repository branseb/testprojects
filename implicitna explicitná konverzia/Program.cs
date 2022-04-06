using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implicitna_explicitná_konverzia
{
    internal class Program
    {
        static void Main(string[] args)
        {   //implicitná konverzia
            int i1 = 5;
            double d1 = i1;
            //implicitná konverzia -menšie do väčšieho dátového typu //int = 4bit , double = 8bit
            //vsetko je v pohode pretypuje
            //
            Console.WriteLine("double:" + d1);
            //zápis bez argumentov znaky treba do ´úvodzoviek ,premenné treba oddeliť pluskom

            //explicitná 
            double d2 = 14.5;
            int i2 = (int)d2;
            //väčší do mensieho dátového typu int do zátvorky ak súklasím zo stratením dát v tomto prípade to je 0.5



            Console.WriteLine("int: {0} double: {1}", i1, i2);
            //argumenty v dvojzátvorkách 0,1,2...za úvodzovkmi vypísem nahrady postupne oddelené čiarkov
            //v úvodozovkách možem argumnty použiť aj viac krát kdekolvek 
            
            //možnosti zápisov:
            //Console.WriteLine($"int: {i1} double:{i2}");
            //-zápis dát priamo do textu pomocov {} a $ pred ""
            //Console.WriteLine("int: {0} double:{1}{1}{0}", i1, i2);
            //-viacnádobné použitie argumentov


            Console.Read();
        }
    }
}
