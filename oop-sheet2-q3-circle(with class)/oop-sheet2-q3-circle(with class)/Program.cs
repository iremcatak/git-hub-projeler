using System;

namespace oop_sheet2_q3_circle_with_class_
{
    class Circle
    {
        public double radius;
        public double circumference;
        public double area;
    }
    class Program
    {
        static void Main(string[] args)
        {
           Circle circle = new Circle();
        
            double pi = 3.14159;

            Console.WriteLine("Enter the radius: ");
            circle.radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");

            //çevre
            circle.circumference = 2 * pi * circle.radius;
            //alan
            circle.area = pi * circle.radius * circle.radius;
            Console.WriteLine("Area of the circle: ");
            Console.WriteLine(circle.area);
            Console.WriteLine("\n");
            Console.WriteLine("Circumference of the circle: ");
            Console.WriteLine(circle.circumference);
        }
    }
}
