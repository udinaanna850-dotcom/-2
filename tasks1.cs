using System;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        int result = 0;
        int step = 1;

        for (int i = a.Length - 1; i >= 0; i--)
        {
            if (a[i] == '1')
            {
                result = result + step;
            }

            step = step * 2;
        }

        Console.WriteLine(result);
    }
}