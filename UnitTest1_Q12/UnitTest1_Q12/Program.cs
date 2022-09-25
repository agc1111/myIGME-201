using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
     * Aidan Carvajal
     * Unit Test 1, Question 12
     */

    internal class Program
    {
        static void Main(string[] args)
        {

            string sName;
            double dSalary = 30000;

            //Prompt for a name
            Console.WriteLine("Enter your name: ");
            sName = Console.ReadLine();

            //Call method
            bool raise = GiveRaise(sName, ref dSalary);

            if (raise == true)
            {
                Console.WriteLine("Congragulations! You got a raise! Your new salary is: " + dSalary);
            }
            else
            {
                Console.WriteLine("Sorry, you did not get a raise.");
            }

        }
        static bool GiveRaise(string name, ref double salary)
        {
            //t/f variable
            bool tf = false;

            //My name
            string myName = "Aidan";

            //If param name = my name
            if (name == myName)
            {
                salary += 19999.999;
                tf = true;
            }

            return tf;

        }

    }
}