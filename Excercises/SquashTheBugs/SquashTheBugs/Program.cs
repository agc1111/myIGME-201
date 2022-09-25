using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    // Class Program
    // Author: Aidan Carvajal
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        // Output N/(N-1) for all 10 numbers
        // and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            double i = 0; //no semicolin; change to double
            string allNumbers = null;

            // loop through the numbers 1 through 10
            //for (i = 1.0; i < 10; ++i)
            for (i = 1.0; i <= 10; ++i) //Must be <= 10 to include 10
            {
                // declare string to hold all numbers
                //string allNumbers = null; allNumbers declared outside of loop

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = "); //No paranthises

                // output the calculation based on the numbers
                Console.WriteLine(i / (i - 1));

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i += 1; Get rid of counter to process all numbers
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}

