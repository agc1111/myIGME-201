using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_Parsing_and_Formatting
{
    internal class Program
    {
        /*
        * AidanCarvajal
        * Create a number guessing game with numbers between 0 - 100, icnlusive
        */

        static void Main(string[] args)
        {
            
            Random rand = new Random();

            int randomNumber = rand.Next(0, 101);
            int userGuess;
            int tries = 1;
            int correct = 0;

            Console.WriteLine("Guess the random number between 0 - 100, inclusive, within 8 guesses!"); //Welcome message
            Console.WriteLine(" ");
            Console.WriteLine("Guess a number between 0 - 100"); //Prompt

            while (tries <= 8)
            {

                try //try-catch to confirm userGuess is an integer
                {
                    userGuess = Convert.ToInt32(Console.ReadLine()); //Needed ToInt32 otherwise it caused errors with userGuess

                    if (userGuess < randomNumber) //If userGuess is less than randomNumber
                    {
                        Console.WriteLine("Too low, try again!");
                        Console.WriteLine(" ");
                    }

                    if (userGuess > randomNumber) //If userGuess is greater than randomNumber
                    {
                        Console.WriteLine("Too high, please try again");
                        Console.WriteLine(" ");
                    }

                    if(userGuess == randomNumber) //If the guess is correct
                    {
                        Console.WriteLine("Congrats! You got it!");
                        correct++;
                        break;
                    }
                }
                catch //Excpetion
                {
                    Console.WriteLine("Please guess an integer between 0 - 100, inclusive.");
                    tries--; //Does not count as a try
                }

                //Lets the user know how amny tries are left and increments
                Console.WriteLine("You have " + (8 - tries) + " guesses remaining.");
                tries++;

            }

            //Ending message to let the player know the game is over
            Console.WriteLine(" ");

            if(correct == 0) //If the player never got it, it tells you the correct number
            {
                Console.WriteLine("The correct number was " + randomNumber);
            }

            Console.WriteLine("Thanks for playing!");


        }
    }
}
