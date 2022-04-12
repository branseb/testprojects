internal class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select ticket: \n 1- Adult 0.5$ \n 2- Senior 0.3$ \n 3- Kids 0.25$");
        string ticketip = Console.ReadLine();
        bool select = false;
        double ticketprince = 0;
        while (select == false)
        {
            if (ticketip == "1")
            {
                ticketip = "Adult";
                ticketprince = 0.5;
                select = true;
            }
            else if (ticketip == "2")
            {
                ticketip = "Senior";
                ticketprince = 0.3;
                select = true;
            }
            else if (ticketip == "3")
            {
                ticketip = "Kids";
                ticketprince = 0.25;
                select = true;
            }
            else
            {
                Console.WriteLine("Wrong choice! \nSelect your ticket!");
                ticketip = Console.ReadLine();

            }

        }
        double returned = 0;
        bool convert = true;
        Console.WriteLine("{0} \nPrince: {1} \nInsert coin!", ticketip, ticketprince);
        while (convert)
        {

            string insert = Console.ReadLine();
            convert = double.TryParse(insert, out double insertodouble);


            returned = insertodouble - ticketprince;
            if (returned < 0.00)
            {
                convert = true;
                Console.WriteLine("Little money! \nInsert coin!");
            }

            else
            {//triedicka
                Console.WriteLine("Back: " + returned + "$");
                convert = false;
            }

        }
        //int return2 =(int) returned/2;
        //int return1 = (int)((returned - return2*2)/1);
        //int return05= (int)((returned - return2*2-return1)/0.5);
        //int return02 = (int)((returned - return2*2 - return1 - return05*0.5)/0.2);
        //int return01 = (int)((returned - return2*2 - return1 - return05*0.5 - return02*0.2)/0.1);
        //int return005 = (int)((returned - return2*2 - return1 - return05*0.5 - return02*0.2 - return01*0.1)/0.05);
        //int return002 = (int)((returned - return2*2 - return1 - return05*0.5 - return02*0.2 - return01*0.1 - return005*0.05)/0.02);
        //int return001 = (int)((returned - return2*2 - return1 - return05*0.5 - return02*0.2 - return01*0.1 - return005*0.05 -return002*0.02)/0.01);

        int eur2 = (int)returned / 2;
        returned = Math.Round(returned - eur2 * 2, 2);
        int eur1 = (int)returned / 1;
        returned = Math.Round(returned - eur1 * 1, 2);
        int eur05 = (int)(returned / 0.5);
        returned = Math.Round(returned - eur05 * 0.5, 2);
        int eur02 = (int)(returned / 0.2);
        returned = Math.Round(returned - eur02 * 0.2, 2);
        int eur01 = (int)(returned / 0.1);
        returned = Math.Round(returned - eur01 * 0.1, 2);
        int eur005 = (int)(returned / 0.05);
        returned = Math.Round(returned - eur005 * 0.05, 2);
        int eur002 = (int)(returned / 0.02);
        returned = Math.Round(returned - eur002 * 0.02, 2);
    
        /*double zvysok2 = returned % 2;
        int return2 = (int)(returned - zvysok2) / 2;
        double zvysok1 = zvysok2 % 1;
        int return1 = (int)((zvysok2 - zvysok1) / 1);
        double zvysok05 = zvysok1 % 0.5;
        int return05 = (int)((zvysok1 - zvysok05) / 0.5);
        double zvysok02 = zvysok05 % 0.2;
        int return02 = (int)((zvysok05 - zvysok02) / 0.2);
        double zvysok01 = zvysok02 % 0.1;
        int return01 = (int)((zvysok02 - zvysok01) / 0.1);
        double zvysok005 = zvysok01 % 0.5;
        int return005 = (int)((zvysok01 - zvysok005) / 0.05);
        double zvysok002 = zvysok005 % 0.02;
        int return002 = (int)((zvysok005 - zvysok002) / 0.02);
        int return001 = (int)(zvysok002 / 0.01);
        */


       //Console.WriteLine("returned \n2$ - {0}pcs \n1$ - {1}pcs \n0.5$ - {2}pcs \n0.2$ - {3}pcs \n0.1$ - {4}pcs \n0.05$ - {5}pcs \n0.02$ - {6}pcs \n0.01$ - {7}pcs", return2, return1, return05, return02, return01, return005, return002, return001);
       Console.WriteLine("returned \n2$ - {0}pcs \n1$ - {1}pcs \n0.5$ - {2}pcs \n0.2$ - {3}pcs \n0.1$ - {4}pcs \n0.05$ - {5}pcs \n0.02$ - {6}pcs \n0.01$ - {7}pcs", eur2, eur1, eur05, eur02, eur01, eur005, eur002, returned);


        File.AppendAllText("cisla.txt","erik 5455 \n");
        string text = File.ReadAllText("cisla.txt");
        Console.WriteLine(text);

        Console.ReadLine();
    }

}


