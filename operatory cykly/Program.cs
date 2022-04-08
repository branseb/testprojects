// See https://aka.ms/new-console-template for more information
namespace operatory_cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)


            {
                /*  Console.WriteLine("Zadaj cislo od 1 do 9:");
                  string cislo = Console.ReadLine();

                  if (cislo == "1")
                  {
                      Console.WriteLine("jeden");
                  }
                  else if (cislo == "2")
                  {
                      Console.WriteLine("dva");
                  }
                  else if (cislo == "3")
                  {
                      Console.WriteLine("tri");
                  }
                  else if (cislo == "4")
                  {
                      Console.WriteLine("štyri");
                  }
                  else if (cislo == "5")
                  {
                      Console.WriteLine("päť");
                  }
                  else if (cislo == "6")
                  {
                      Console.WriteLine("šesť");
                  }
                  else if (cislo == "7")
                  {
                      Console.WriteLine("sedem");
                  }
                  else if (cislo == "8")
                  {
                      Console.WriteLine("osem");
                  }
                  else if (cislo == "9")
                  {
                      Console.WriteLine("deväť");
                  }
                  else
                  {
                      Console.WriteLine("Neplatné číslo!!!");
                  }
                 

            }
            Console.WriteLine("Napis cislo od 1 o 9 :");
            string cislo = Console.ReadLine();
           string slovo= Cisla.Getnumbername(cislo);
            Console.WriteLine(slovo);

            Console.ReadLine();
        }*/
            }
            /*Console.WriteLine("zadaj pocet: ");
            string cislo = Console.ReadLine();
            int pocet = int.Parse(cislo);


            for (int i = pocet; i > 0; i--) //1.podmienka je začiatočný počet , 2.podmienka pokial platí podmienka tak sa bude opakovať cyklus v zátvorkách
           
            //3.premenná sa po vykonaní jedneho cyklu zmenší -- alebo zvačší ++
            {
               for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    
                }
               Console.WriteLine();
            }
            Console.ReadLine();*/

            //while (true)

            {
                //Console.WriteLine("Number?");
                // string number = Console.ReadLine();

                // int numbint = int.Parse(number);
                int numbint = 1;
                while (numbint < 1000)
                {
                    bool jePrvocislo = true;

                    for (int i = 2; i < numbint; i++)
                    {
                        int zvysok = numbint % i;
                        if (zvysok == 0)
                        {
                            jePrvocislo = false;
                            break;
                        }

                    }
                
                    if (jePrvocislo)
                        Console.WriteLine(numbint);

                    numbint++;
                    
                }
            }
        }
    }
}