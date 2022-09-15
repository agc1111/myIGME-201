using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE7_Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string:");
            string line =  Console.ReadLine();
            string dq;

            for(int i = 0; i < line.Length; i++)
            {
                dq += line[i];

                dq.Replace(" ", "'");
            }

        }
    }
}
