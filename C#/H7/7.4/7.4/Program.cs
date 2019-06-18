using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging)
            //to run your app.
            Console.WriteLine("geef de tempratuur.");
            string invoer = Console.ReadLine();
            int tempratuur = int.Parse(invoer);
            int counter = 0;


            while (tempratuur != -100)
            {
                Console.WriteLine("geef de tempratuur.");
                invoer = Console.ReadLine();
                tempratuur = int.Parse(invoer);


                if (tempratuur > 20)
                {
                    counter++;

                }

            }


                while(tempratuur == -100)
                {

                    Console.Write("Aantal dagen boven de 20 graden:");
                    

                    Console.WriteLine(counter);
                    Console.WriteLine("Het programma wordt afgesloten");

                    invoer = Console.ReadLine();
                    tempratuur = int.Parse(invoer);

                }
                

            
            // Go to http://aka.ms/dotnet-get-started-console 
            //to continue learning how to build a console app! 
        }
    }
}
