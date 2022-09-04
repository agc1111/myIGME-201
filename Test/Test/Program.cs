using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteFood = "a";
            switch (favoriteFood)
            {
                case ("spaghetti"):
                    Console.WriteLine("You seem to really like spaghetti");
                    break; //ADDED
                case ("cake"):
                    Console.WriteLine("Wrong. Spaghetti is the best food.");
                    break;
                //default():  
                default: 
                    Console.WriteLine("You should like spaghetti.");
                    break;
            }



        }

    }
}
