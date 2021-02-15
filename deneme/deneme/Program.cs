using System;

namespace deneme
{
    class Roots
    {
        public double a = 0;
        public double b = 0;
        public double c = 0;
        public double x1;
        public double x2;
    }

    class Program
    {
        static void Main()
        {
            Roots roots = new Roots();

            Console.WriteLine("For calculating the roots of the second order equation(ax^2+bx+c),Please enter");
            Console.WriteLine("a: ");
            roots.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b: ");
            roots.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c: ");
            roots.c = Convert.ToDouble(Console.ReadLine());


            if (Convert.ToBoolean(roots.a == 0))
            {
                Console.WriteLine("Error,This is not a second order equation.");
            }
            else if (Convert.ToBoolean(roots.a != 0))
            {
                roots.Print();
            }
        }

        class Roots
        {
            public double a { get; set; } = 0;
            public double b { get; set; } = 0;
            public double c { get; set; } = 0;
            public double x1 => (-b + Math.Sqrt(Delta)) / (2 * a);
            public double x2 => (-b - Math.Sqrt(Delta)) / (2 * a);

            public double Delta => b * b - 4 * a * c;

            public void Print()
            {
                if (Delta < 0)
                {
                    Console.WriteLine("Error,No real roots available for this equation.");
                }
                else
                {
                    Console.WriteLine("x1= " + x1);
                    Console.WriteLine("x2= " + x2);
                }

            }
        }
    }
}
