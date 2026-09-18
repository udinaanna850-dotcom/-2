using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        string result = "";

        while (a > 0)
        {
            result = (a % 2) + result;
            a = a / 2;
        }

        Console.WriteLine(result);
    }
}
