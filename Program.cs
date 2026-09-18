using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int t = int.Parse(Console.ReadLine());

        m = m + t;

        n = n + m / 60;
        m = m % 60;

        n = n % 24;

        Console.WriteLine(n + ":" + m);
    }
}