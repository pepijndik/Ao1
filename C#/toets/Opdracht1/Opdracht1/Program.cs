using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pepijn dik");
            Console.WriteLine("CijferReeks");
            Console.WriteLine("Vul de getallenReeiks aan");
            Console.WriteLine("Dit is de reeks : 0 1 3 6 10");
            Console.WriteLine("Hoeveel getallen wil je toevoegen?");

            string invoer = Console.ReadLine();
            int aantal = int.Parse(invoer);
            int beginGetal = 10;
           
            while (aantal != 0)
            {
                for (int teller = 1; teller <= aantal; teller++)
                {

                    int plus = 4 + teller;
                    int totaal = beginGetal + plus;
                    
                    if (totaal == totaal)
                    {
                        int nieuw = totaal + plus;
                        Console.WriteLine(nieuw.ToString());
                    }

                  
                }
                Console.ReadLine();
            }
            


        }
    }
}
