using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE7_Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string with 'yes' or 'no' in it:");
            string userLine = Console.ReadLine();
            string resultLine = userLine.ToLower();

            resultLine.Replace('no', 'yes').Replace('yes', 'no');

            Console.WriteLine("Your new string: ");
            Console.WriteLine(resultLine);
        }
    }
}
