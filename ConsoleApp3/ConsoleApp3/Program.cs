

using System;

namespace ConsoleApp3
{
    class Program
    {
        class AAA
        {
            protected int x, y;
            public float F(int a, float b)
            {
                return a * b;
            }
        }
        class BBB : AAA
        {
            public int z;
            public float w;
            public BBB(int a, float b)
            {
                z = a ;w = b;
            }
        }
        class CCC : BBB
        {
            public int w1, w2;
            public int CCC (int A1,int A2,float A3) : base(A1,A3){
                w1 = A1; w2 = A2;x = 0;y = 0;
            }
        }
        static void Main(string[] args)
        {
            CCC Obj = new CCC();
           
            int R1 = Obj.x;
            float R2 = Obj.F(3, 5.0f);
            Console.WriteLine(R1);
        }
    }
}
