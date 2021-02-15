using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExercise
{
    class process
    {
        public int sum(int num1,int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine("Result:" + num3);
            return num3;
        }
        public int cube( int n)
        {
            int result = n * n;
            Console.WriteLine("Result:"+ result);
            return result;
        }
    }
}
