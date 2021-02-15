using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_question_3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int number, i, num = 0, a = 0;
            Console.WriteLine("Please, enter the number between 0-500  ");
            number = int.Parse(Console.ReadLine());
            num = number / 2;
            for (i = 2; i <= num; i++)
            {
                if (number % i == 0)
                {
                    Console.Write("This is not a prime number= ");
                    a = 1;
                    break;
                }
            }
            if (a == 0)
                Console.Write("This is a prime number= ");
            Console.Write(number);
            
        }
    }
}
