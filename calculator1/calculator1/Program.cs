
using System;

namespace calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int num1, num2 = 0;

          
            Console.WriteLine("Console Calculator in C#\r");  
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:\n\ta - Add\n\ts - Subtract\n\tm - Multiply\n\td - Divide");
         
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        
    }
    }
}
