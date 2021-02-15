using System;
public struct AccountStruct
{

    string username;
    int number;
    int dateOfActivation;
    int balance;



    public static void MyMethod()
    {
        String[] names = { "Muhammed", "Ali", "Omer", "Osman", "Bekir" };
        int[] numbers = { 431, 940, 832, 487, 109 };
        int[] balance = { 1000, 7000, 9000, 14000, 2000 };
        int max = numbers[0];
        int sum = 0;
        int temp = 0;
        int average = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Account Name= " + names[i] + " Account Number= " + numbers[i] + " Balance= " + balance[i]);
            sum += balance[i];
            average = sum / balance.Length;

        }


        for (int h = 0; h < 4; h++)
        {
            for (int j = h + 1; j <= 4; j++)
            {
                if (numbers[h] > numbers[j])
                {
                    temp = numbers[h];
                    numbers[h] = numbers[j];

                    numbers[j] = temp;
                }
            }
        }
        Console.WriteLine("Sorting account number low to high");
        for (int a = 0; a < 5; a++)
        {
            Console.Write(numbers[a] + " ");

        }
        Console.WriteLine("\nAverage of Balances= " + average);


        for (int h = 0; h < 4; h++)
        {
            for (int j = h + 1; j <= 4; j++)
            {
                if (balance[h] > balance[j])
                {
                    temp = balance[h];
                    balance[h] = balance[j];

                    balance[j] = temp;
                }
            }
        }
        Console.WriteLine("Sorting account balance low to high");
        for (int a = 0; a < 5; a++)
        {
            Console.Write(balance[a] + " ");


        }
        for (int x = 1; x < balance.Length; x++)
        {
            if (balance[x] > max)
            {
                max = balance[x];
            }
        }
        Console.WriteLine("\nMax Balance= " + max);



    }

    public static void Main(string[] args)
    {
        MyMethod();
    }
}
