using System;
namespace midterm_question_2
{

    class Program
    {
      
        public static void Main(string[] args)
        {


           int first = 0;

             int[] number = new int[5];

             for (int k = 0; k <= 4; k++)
             {
                 Console.Write("Enter any integer between 0-20: ");
                 number[k] = Convert.ToInt16(Console.ReadLine());

             }
            Console.Write("The given numbers to be sorted: ");
            foreach (int value in number)
            {
                Console.Write(value + " "); 
             
            }
            Console.Write("\n");
            for (int i = 0; i < 4; i++)
             {

                 for (int j = i + 1; j <= 4; j++)
                 {
                     if (number[i] < number[j])
                     {
                         first = number[j];
                         number[j] = number[i];
                         number[i] = first;
                     }
                 }
             }
          
            Console.WriteLine("High to Low Sort: ");
             for (int a = 0; a < 5; a++)
             {
                 Console.Write (" "+number[a]);
             }
            Console.WriteLine("\n");
            Console.WriteLine("Low to High Sort: ");
            
            Array.Reverse(number);
            for (int a = 0; a < 5; a++)
            {
                Console.Write(" " + number[a]);
            }
        }

    }
}

