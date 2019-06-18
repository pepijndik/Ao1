using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Press Ctrl+F5 (or go to Debug > Start Without Debugging)
            //to run your app.
            

            //starts at 0 and multiplies by 2
            for (int teller = 0; teller <= 100;  teller+=2)
            {
                Console.WriteLine(teller.ToString());
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console
            //to continue learning how to build a console app! 
        }
    }
}
