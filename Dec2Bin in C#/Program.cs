using System;

// Namespace Dec2Bin
namespace Dec2Bin
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            string appName = "Dec2Bin Converter";
            string appVersion = "1.0.0";
            string appAuthor = "Endrijs Aizbalts";
            
            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            
            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            
            //Reset text color
            Console.ResetColor();
            
            // Ask for a decimal number
            Console.Write("Enter your Decimal Number : ");
            
            // Get decimal number
            int number = int.Parse(Console.ReadLine());
            int i;
            int[] numberArray = new int[10];
            for (i = 0; number > 0; i++)
            {
                numberArray[i] = number % 2;
                number = number / 2;
            }

            Console.Write("Converted to Binary Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(numberArray[i]);
            }

            Console.ReadKey();
        
        }
    }
}