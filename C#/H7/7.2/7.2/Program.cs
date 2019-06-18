using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging)
            //to run your app.


            
            int grensgetal = 6;
            // laat grensgetal zien.
            Console.WriteLine(grensgetal.ToString());
            Console.WriteLine("De getallen zijn:".ToString());


            //telt to grensgetal maar stopt het grensgetal
            for (int teller = 1; teller < grensgetal; teller++)
            {
                Console.WriteLine(teller.ToString());
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console 
            //to continue learning how to build a console app! 
        }
    }
}
