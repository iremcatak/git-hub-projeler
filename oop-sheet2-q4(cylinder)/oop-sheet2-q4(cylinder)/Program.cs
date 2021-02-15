using System;

namespace oop_sheet2_q4_cylinder_
{
    class Cylinder
    {
        
        public double radius;
        public double height;

        private double areaCircle;
        private double premiereCircle;

        public double surfaceArea
        {
            get { return areaCircle; }
            set { areaCircle = value; }
            
        }
        public double volume
        {
            get { return premiereCircle; }
            set { premiereCircle = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
         Cylinder cylinder = new Cylinder();

            double pi = 3.14159;

           //store radius
           Console.WriteLine("Enter the radius: ");
           cylinder.radius = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("\n");
           //store height
           Console.WriteLine("Enter the height: ");
           cylinder.height = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("\n");

            //method calculate surfacearea and volume
            cylinder.volume = pi * cylinder.radius * cylinder.radius * cylinder.height;
            cylinder.surfaceArea = (2 * pi * cylinder.radius * cylinder.radius) + (2 * pi * cylinder.radius * cylinder.height);
           Console.WriteLine("Surface area of the cylinder: ");
           Console.WriteLine(cylinder.surfaceArea);
           Console.WriteLine("\n");
           Console.WriteLine("Volume of the cylinder: ");
           Console.WriteLine(cylinder.volume);

        }
    }
}
