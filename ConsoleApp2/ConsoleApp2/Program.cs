using System;

namespace ConsoleApp2
{
    class Program
    {
        class AAA
        {
            protected int x, y;
            public virtual int F(int a,int b)
            {
                return a * b;
            }
        }
        class BBB:AAA
        {
            public int z, w;
            public override int F(int a, int b)
            {
                return a + b;
            }
        }
        static void Main(string[] args)
        {
            AAA Obj1 = new AAA();
            BBB Obj2 = new BBB();
            int R1 = Obj1.F(2, 5);
            int R2 = Obj2.F(2, 5);
            Console.WriteLine(R2);
        }
    }
}
