using System;


namespace MandelbrotModify
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>


        //DOES NOT WORK DID NOT GET TO FINISH
        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            //Created new variables for the start and end of each (has the default values)

            double startImg = 1.2;
            double endImg = -1.2;
            double startReal = -0.6;
            double endReal = 1.77;


            //Loops to make sure the inputed numbers are correct

            for(int check = 0; check < 1; check++)
            {
                Console.WriteLine("Enter a new start for imagCoord");
                startImg = Console.Read();
                Console.WriteLine("Enter a new end for imagCoord");
                endImg = Console.Read();
                
                if(endImg > startImg)
                {
                    Console.WriteLine("endImg MUST be less than startImg");
                    check = 0;
                }
            }
            
            for(int check = 0; check < 1; check++)
            {
                Console.WriteLine("Enter a new start for realCoord");
                startReal = Console.Read();
                Console.WriteLine("Enter a new end for realCoord");
                endReal = Console.Read();

                if (endReal < startReal)
                {
                    Console.WriteLine("endReal MUST be greater than startReal");
                }
            }
            

            Console.WriteLine(" ");


            //Assigns the start and end values to imagCoord and reakCoord
            for (imagCoord = startImg; imagCoord >= endImg; imagCoord -= 0.05)
            {
                for (realCoord = startReal; realCoord <= endReal; realCoord += 0.03)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);

                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }

                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
