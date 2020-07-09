using System;

namespace AfterHoursBackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            var userInput = Console.ReadLine();
            var isDecimal = decimal.TryParse(userInput, out decimal userInputAsDecimal);

            if (!isDecimal)
            {
                Console.WriteLine("Error - incorrect input - Try again");
                return;
            }
            userInputAsDecimal += 0.5m;
            Console.WriteLine(userInputAsDecimal);


        }
    }
}
