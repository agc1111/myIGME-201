using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Boolean b1 = false;
            Boolean b2 = false;

            try
            {
                Console.WriteLine("Enter an integer:");
                int var1 = Convert.ToInt32(Console.ReadLine());
                if(var1 > 10)
                {
                    b1 = true;
                    Console.WriteLine("Is " + var1 + " greater than 10: True.");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Is " + var1 + " greater than 10: False.");
                    Console.WriteLine(" ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Not an integer.");
                Console.WriteLine(" ");
            }

            try
            {
                Console.WriteLine("Enter an integer:");
                int var2 = Convert.ToInt32(Console.ReadLine());
                if(var2 > 10)
                {
                    b2 = true;
                    Console.WriteLine("Is " + var2 + " greater than 10: True.");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Is " + var2 + " greater than 10: False.");
                    Console.WriteLine(" ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Not an integer.");
                Console.WriteLine(" ");
            }

            Boolean fResult = b1 ^ b2;

            Console.WriteLine(b1 + " ^ " + b2 + " = " + fResult);
            Console.ReadLine();
        }
    }
}
