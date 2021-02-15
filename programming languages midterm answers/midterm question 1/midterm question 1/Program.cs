using System;

namespace midterm_question_1
{
    class Car
    {
      public  string brand = "Ferrari";
      public  string color = "blue";
      public  int year = 2020;
      public  int cylinder = 8;

    }
    class Truck
    {
        public string brand = "Volvo";
        public string color = "White";
        public int year = 2015;
        public string capacity="40 ton";

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Console.WriteLine("model= "+myCar.brand+"\n"+"color= "+myCar.color+ "\n"+"year= "+myCar.year+ "\n"+"cylinder= "+myCar.cylinder);
            Truck myTruck = new Truck();
            Console.WriteLine("model= " + myTruck.brand + "\n" + "color= " + myTruck.color + "\n" + "year= " + myTruck.year + "\n" + "capacity= " + myTruck.capacity);
        }
    }
}
