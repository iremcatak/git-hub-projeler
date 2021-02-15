using System;

namespace ConsoleApp1
{
    class Program
    {
        class AAA
        {
            public int x, y;
            public float F(int a,float b)
            {
                return a * b;
            }
            public int F(int a, int b)
            {
                return a + b;
            }
       
            public AAA(int a, int b)
            {
                x = a; y = b; ;
            }
        }
        class BBB
        {
            public int z;
            public float w;
            public BBB (int a,float b,int c, int d):base( c, d)
            {
                z = a;w = b;
            }
        }

        static void Main(string[] args)
        {
            AAA Obj = new AAA(5,6);
            BBB Obj2 = new BBB(1, 2, 4, 5);
            int R1 = Obj2.F(2, 5);
            float R2 = Obj2.F(2, 5.0f);
            Console.Write(R2);
        }
    }
}
