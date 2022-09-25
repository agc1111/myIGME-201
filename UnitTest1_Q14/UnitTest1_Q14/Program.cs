using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;

            //int nY [SYNTAX ERROR; no ";" at the end]
            int nY;

            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.); [SYNTAX ERROR; No quotations]
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");

               //Console.ReadLine(); [LOGIC ERROR; Assign sNumber to line
               sNumber = Console.ReadLine();

            } while (!int.TryParse(sNumber, out nX)); 

            do
            {
                Console.Write("Enter a positive whole number for y: ");

                sNumber = Console.ReadLine();
            } //while (int.TryParse(sNumber, out nX)); [LOGIC ERROR; nY istead of nX]
                while (int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            Console.WriteLine("{nX}^{nY} = {nAnswer}");
        }


        //int Power(int nBase, int nExponent) [RUNTIME ERROR; static method]
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 0;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                nextVal = Power(nBase, nExponent + 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal; [RUNTIME ERROR; must return]
            return returnVal;
        }
    }
}

