using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PE7_MadLib
{
    /*
     * Aidan Carvajal
     * Meant to play a game of Mad Libs
     * DID NOT FINISH
     */

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Do you want to play Mad Libs? Yes or No?");
            int check = 0;

            while(check == 0)
            {
                try
                {
                    string response = Console.ReadLine();

                    if(response == "Yes" || response == "yes")
                    {

                    }
                    else if(response == "No" || response == "no")
                    {
                        Console.WriteLine("Goodbye.");
                    }
                }
                catch
                {
                    Console.WriteLine("Do you want to play? Yes or no?");
                }
                
            }

            if (check == 1) {

                int numLibs = 0;
                int count;
                int nChoice;

                string resultString;

                StreamReader input;

                input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

                string line = null;

                while (line = null)
                {
                    ++numLibs;
                }

                input.Close();

                string[] madLibs = new string[numLibs];

                input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

                line = null;
                while ((line = input.ReadLine()) != null)
                {

                    madLibs[count] = line;

                    madLibs[count] = madLibs[count].Replace("\\n", "\n");

                    ++count;
                }

                input.Close();

                string[] words = madLibs[nChoice].Split(' ');

                foreach (string word in words)
                {

                    if (word[0] == '{')
                    {
                        word = word.Replace("{", "").Replace("}", "").Replace("_", "");

                        Console.Write("Input a {0}: ", word);

                        resultString += Console.ReadLine();
                    }
                    else
                    {
                        resultString += word;
                    }
                }

            }
        }
    }
}
