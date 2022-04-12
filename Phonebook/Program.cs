namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phonebook = "phonebook.txt";
            File.AppendAllText(phonebook,"");
            Console.WriteLine("Phonebook"+Environment.NewLine+"Press \"n\" for New contact or \"o\" for open Phonebook");
            while (true)
            {
               
                char select = Console.ReadKey().KeyChar;
                Console.WriteLine();
                string[] books = File.ReadAllLines(phonebook);
                var fltere = books.Where(row => row.Contains("er"));
                if (select == 'n')
                {
                    Console.WriteLine("Whrite The Name:");
                    string newcontname = Console.ReadLine();
                    Console.WriteLine("Number on {0} ?", newcontname);
                    string newcontnum = Console.ReadLine();
                    File.AppendAllText(phonebook, newcontname + " - " + newcontnum + Environment.NewLine);
                    Console.WriteLine("Saved!");
                }
                else if (select == 'o')
                {
                    Console.Write("Contacts:" + Environment.NewLine + string.Join(Environment.NewLine, fltere)); 
                    
                }

                else
                {
                    Console.WriteLine("Wrong choice!");
                }
            }
        }
    }
}
