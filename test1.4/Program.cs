using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Ahoj,zadaj prvé slovo.");

            string slovo1 = Console.ReadLine();

            Console.WriteLine("zadaj druhé slovo");
            string slovo2 = Console.ReadLine();
            int pocet1 = slovo1.Length;
            int pocet2 = slovo2.Length;
            Console.WriteLine("majú rovnkaký počet znakov? PRE POKRAČOVANIE STLAČ ENTER . . . ");
            Console.ReadLine();
            bool parny = (pocet1 == pocet2);
            string vysledok = parny ? "ano" : "nie ";
            Console.WriteLine(vysledok);
            // string // dátový typ
            // slovo1.Aggregate//premenna typu string
            Console.ReadLine();
            */
            //var text = "hello world";

            // Console.WriteLine("string.Length - premenna - vracia počet znakov");
            // Console.WriteLine(text + text.Length);

            //text.Substring;
            /* string text = Console.ReadLine();
             bool zaciatok = text.StartsWith("erik");
             bool koniec = text.EndsWith("parso");
             bool boris = text.Contains("boris");
             bool erik = text.Contains("erik");
             bool mena = !(erik && boris);

             bool final = (( zaciatok && koniec) || boris )&&(mena);

             string vysledok = final ?"ano":"nie";
             Console.WriteLine(vysledok);
            */
            string den = DateTime.Now.ToString();
            string datum = den.Substring(0, den.Length - 8);
            Console.WriteLine("Dátum : " + datum );
            Console.WriteLine("ako sa voláš?");
            string meno = Console.ReadLine();
            Alarm.PozdravMa(meno);
            
            Console.WriteLine("Ako sa máš  ?");
            string nalada = Console.ReadLine();
            bool dobre = nalada.Contains("dobre");
            bool zle = nalada.Contains("zle");
            string dobreodpoved = dobre ? "som rád že máš dobrú náladu " +meno :"";
            string zleodpoved = zle ? "môžem ti zlepšiť náladu "+meno + " ?" : "";
            Console.WriteLine(dobreodpoved + zleodpoved);
            Console.ReadLine();
           
           





















            Console.ReadLine();
            
        
               

        }
    }
}
