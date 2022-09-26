using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ans = "";\

            string ans1 = "blue";
            string ans2 = "42";
            string ans3 = "What do you mean? African or European swallow?";

            Console.WriteLine("Choose your question (1-3): ");

            int check = 0;
            int numPick = Console.Read();

            while(check == 0)
            {
                if(numPick >= 1 || numPick <= 3)
                {
                    check++;
                    break;
                }

                Console.WriteLine("Choose your question (1-3): ");
                numPick = Console.Read();

            }

            Console.WriteLine("You have 5 seconds to answer this question!");

            if(numPick == 1)
            {
                Console.WriteLine("What is your favoirte color?");
                ans = Console.ReadLine();

                if(ans == ans1)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong! The asnwer is " + ans1);
                }

            }else if(numPick == 2)
            {
                Console.WriteLine("What is the answer to life, the universe and everything?");
                ans = Console.ReadLine();

                if(ans == ans2)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong! The answer is " + ans2);
                }

            }else if(numPick == 3)
            {
                Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                ans = Console.ReadLine();

                if(ans == ans3)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong! The answer is " + ans3);
                }
            }

            Console.WriteLine("Would you like to play again?");

            
           

        }
    }
}
