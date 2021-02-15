using System;

namespace oop__question_1
{
    class Program
    {
        struct circle
        {
            public double radius;
            public double circumference;
            public double area;

        }
        static void Main(string[] args)
        {
            circle cir = new circle();
        
            double pi = 3.14159;

            Console.WriteLine("Enter the radius: ");
            cir.radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");

            //çevre
            cir.circumference = 2 * pi * cir.radius;
            //alan
            cir.area = pi * cir.radius * cir.radius;
            Console.WriteLine("Area of the circle: ");
            Console.WriteLine( cir.area);
            Console.WriteLine("\n");
            Console.WriteLine("Circumference of the circle: ");
            Console.WriteLine(cir.circumference);



           

        }
    }
}
