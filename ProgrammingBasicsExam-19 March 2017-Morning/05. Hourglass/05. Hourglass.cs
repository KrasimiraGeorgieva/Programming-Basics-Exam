using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var rowLenght = 2 * n + 1;

        Console.WriteLine("{0}", new string('*', 2 * n + 1));
        Console.WriteLine("{0}*{1}*{0}", new string('.', 1), new string(' ', rowLenght - 4));

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', 2 + i), new string('@', rowLenght - 6 - i * 2));
        }

        Console.WriteLine("{0}*{0}", new string('.', n));

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', n - 1 - i), new string(' ', i));
        }

        Console.WriteLine("{0}*{1}*{0}", new string('.', 1), new string('@', rowLenght - 4));
        Console.WriteLine("{0}", new string('*', 2 * n + 1));
    }
}
