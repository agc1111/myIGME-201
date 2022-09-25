using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string you want reversed: ");
            string userLine = Console.ReadLine();
            string reverse = "";

            for(int i = userLine.Length - 1; i >= 0; i--)
            {
                reverse += userLine[i];
            }

            Console.Write("Your string reversed: ");
            Console.WriteLine(reverse);
        }
    }
}
