namespace Phonebook
{
    public class Program
    {
        static void Main(string[] args)
        {
            var phonebook = "phonebook.txt";
            File.AppendAllText(phonebook,"");
            Console.WriteLine("Phonebook"+Environment.NewLine+"Press \"n\" for New contact , \"o\" for open Phonebook or  \"s\" for search coctact");
            while (true)
            {
               
                var select = Console.ReadKey().KeyChar;
                Console.WriteLine();
                
                if (select == 'n')
                {
                    Console.WriteLine("Whrite The Name:");
                    var newcontname = Console.ReadLine();
                    Console.WriteLine("Number on {0} ?", newcontname);
                    var newcontnum = Console.ReadLine();
                    File.AppendAllText(phonebook, newcontname + " - " + newcontnum + Environment.NewLine);
                    Console.WriteLine("Saved!");
                }
                else if (select == 'o')
                {
                    //Console.Write("Contacts:" + Environment.NewLine + File.ReadAllLines(phonebook));
                    foreach (var line in File.ReadAllLines(phonebook))
                    {
                        Console.WriteLine(line);
                    }


                }
                else if (select == 's')
                {
                    Console.WriteLine("Search?");
                    var search = Console.ReadLine();
                    var books = File.ReadAllLines(phonebook);
                    var filtere = books.Where(row => row.ToLower().Contains(search));
                    Console.Write("Contacts:" + Environment.NewLine + string.Join(Environment.NewLine, filtere));
                }

                else
                {
                    Console.WriteLine("Wrong choice!");
                }
            }
        }
    }
}
