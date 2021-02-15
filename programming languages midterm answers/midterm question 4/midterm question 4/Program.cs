using System;

namespace midterm_question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 2;
            int Max = 1000;
            int i, j, k;
           
            int[] list = new int[5];
            Console.Write("These are numbers in array: ");
            Random randnum = new Random();
            for (i = 0; i < list.Length; i++)
            {
                list[i] = randnum.Next(Min, Max);
                Console.Write(" " + list[i]);
               
               
            }
           
            for (i = 0; i < list.Length; i++)
            {
                j = 2;
                k = 1;
                while (j < list[i])
                {
                    if (list[i] % j == 0)
                    {
                        k = 0; 
                        break;
                       
                    }
                    j++;
                    
                }
                Console.WriteLine("\nThis is not a prime number= "+ list[i]);
                
                if (k == 1)
                {
                    Console.WriteLine("\nThis is a prime number= "+ list[i]);
                   
                }
                
              
            }

        }
    }
}

       


    
    


