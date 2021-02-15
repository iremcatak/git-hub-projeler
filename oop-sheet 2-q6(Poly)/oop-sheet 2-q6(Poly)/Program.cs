using System;

namespace oop_sheet_2_q6_Poly_

{
    class Poly
    {
        public int x, a, b, c, d, e, f;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Poly plynm = new Poly();
            //number of argument parameters
            int numofprmtrs;
            double Result;
           
            Console.WriteLine("Enter the number of integers you want to calculate\n(Minimum 4 integers (For 2nd order up)---Maximum 7 integers(For 5th order up): ");
            numofprmtrs = Convert.ToInt32(Console.ReadLine());

            if (numofprmtrs < 4)
            {
                Console.WriteLine("Error,Not enough input parameters");
            }
            else if(numofprmtrs==4)
            {
                Console.WriteLine("Please enter parameters(for ax^2+bx+c)");
                Console.WriteLine("a: ");
                plynm.a=  Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("b: ");
                plynm.b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("c: ");
                plynm.c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("x: ");
                plynm.x = Convert.ToInt32(Console.ReadLine());
                Result = (plynm.a*plynm.x*plynm.x+plynm.b*plynm.x+plynm.c);
                Console.WriteLine("Result= "+Result);
            }
            else if (numofprmtrs == 5)
            {
                Console.WriteLine("Please enter parameters(for ax^3+bx^2+cx+d)");
                Console.WriteLine("a: ");
                plynm.a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("b: ");
                plynm.b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("c: ");
                plynm.c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("d: ");
                plynm.d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("x: ");
                plynm.x = Convert.ToInt32(Console.ReadLine());
                Result = (plynm.a * plynm.x * plynm.x* plynm.x + plynm.b * plynm.x * plynm.x + plynm.c* plynm.x+plynm.d);
                Console.WriteLine("Result= " + Result);
            }
            else if (numofprmtrs == 6)
            {
                Console.WriteLine("Please enter parameters(for ax^4+bx^3+cx^2+dx+e)");
                Console.WriteLine("a: ");
                plynm.a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("b: ");
                plynm.b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("c: ");
                plynm.c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("d: ");
                plynm.d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("e: ");
                plynm.e = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("x: ");
                plynm.x = Convert.ToInt32(Console.ReadLine());
                Result = (plynm.a * plynm.x * plynm.x * plynm.x * plynm.x + plynm.b * plynm.x * plynm.x * plynm.x + plynm.c * plynm.x * plynm.x + plynm.d * plynm.x+plynm.e);
                Console.WriteLine("Result= " + Result);
            }
            else if (numofprmtrs == 7)
            {
                Console.WriteLine("Please enter parameters(for ax^5+bx^4+cx^3+dx^2+ex+f)");
                Console.WriteLine("a: ");
                plynm.a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("b: ");
                plynm.b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("c: ");
                plynm.c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("d: ");
                plynm.d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("e: ");
                plynm.e = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("f: ");
                plynm.f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("x: ");
                plynm.x = Convert.ToInt32(Console.ReadLine());
                Result = (plynm.a * plynm.x * plynm.x * plynm.x * plynm.x * plynm.x + plynm.b* plynm.x * plynm.x * plynm.x * plynm.x + plynm.c * plynm.x * plynm.x * plynm.x + plynm.d * plynm.x * plynm.x + plynm.e* plynm.x+plynm.f);
                Console.WriteLine("Result= " + Result);
            }

                    
        }
        }
    }

