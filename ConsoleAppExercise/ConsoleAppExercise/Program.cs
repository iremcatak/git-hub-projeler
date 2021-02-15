using System;

namespace ConsoleAppExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Hello :) ");
            Console.WriteLine(" It is me");
            string word;
            word = "Adele";
            Console.WriteLine(word);
            Console.ReadKey();*/
            //-------------------------------------
            /*Message mssge = new Message();
            mssge.text();
            Console.Read();*/
            //-------------------------------------
            /*process prcss = new process();
            prcss.sum(42, 341);
            prcss.cube(6);
            Console.Read();
            */
            //-------------------------------------
            /* student stnd = new student("Francesc- book club");
             Console.Read();*/
            ID id = new ID();
            id.NAME = "Dicle";
            id.SURNAME = "plane";
            id.HOMETOWN = "Turkey";
            id.AGE = 17;
            id.GENDER = 'M';
            Console.WriteLine(id.NAME);
            Console.WriteLine(id.SURNAME);
            Console.WriteLine(id.AGE);
            Console.WriteLine(id.HOMETOWN);
            Console.WriteLine(id.GENDER);
            Console.Read();
        }
    }
}
