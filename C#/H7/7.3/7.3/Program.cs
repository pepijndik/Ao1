using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging)
            //to run your app.


            //begin van code
            Console.WriteLine("Voer een getal in");
            string invoer = Console.ReadLine();
            int getal = int.Parse(invoer);

          
               
            while (getal != 0)
            {
                //berkening van kwadraat en herhaalt zich weer.
                int kwadraat = getal * getal;

                Console.Write("het kwadraat is:");
                Console.WriteLine(kwadraat);
                

                Console.WriteLine("geef getal");
                invoer = Console.ReadLine();
                int.Parse(invoer);
                // wanneer 0 program exit
                if (int.Parse(invoer) == 0)
                {
                    Console.WriteLine("je hebt op 0 gedrukt, het programma wordt gesloten...");
                    return;
                }
                
            }



            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
