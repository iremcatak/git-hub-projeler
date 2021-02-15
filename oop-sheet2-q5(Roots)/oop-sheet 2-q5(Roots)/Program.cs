using System;

namespace oop_sheet_2_q5_Roots_
{
    class Roots
    {
        public double a { get; set; } = 0;
        public double b { get; set; } = 0;
        public double c { get; set; } = 0;
        public double x1;
        public double x2;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Roots roots = new Roots();
            double thesquareroot;
            double delta;
            Console.WriteLine("For calculating the roots of the second order equation(ax^2+bx+c),Please enter");
            Console.WriteLine("a: ");
            roots.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b: ");
            roots.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c: ");
            roots.c = Convert.ToDouble(Console.ReadLine());


            if (roots.a.Equals(0.0))
            {
                Console.WriteLine("Error,This is not a second order equation.");
            }
            else
            {
                delta = roots.b * roots.b - 4 * roots.a * roots.c;

                if (delta < 0)
                {
                    Console.WriteLine("Error,No real roots available for this equation.");
                }
                else
                {
                    thesquareroot = Math.Sqrt(delta);
                    roots.x1 = (-roots.b + thesquareroot) / (2 * roots.a);
                    roots.x2 = (-roots.b - thesquareroot) / (2 * roots.a);

                    Console.WriteLine("x1= " + roots.x1);
                    Console.WriteLine("x2= " + roots.x2);
                }
            }
        }
    }
}