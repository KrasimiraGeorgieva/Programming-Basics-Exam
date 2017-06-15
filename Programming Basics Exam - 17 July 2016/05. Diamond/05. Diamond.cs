using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var rowLenght = 5 * n;

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));

        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n-1-i), new string ('.', rowLenght - 2 - (n-1-i)*2));
        }

        Console.WriteLine(new string('*', 5 * n));

        for (int i = 0; i < 2*n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', i+1), new string('.', rowLenght - 4 - i * 2));
        }

        Console.WriteLine("{0}{1}{0}", new string('.', 2*n+1), new string('*', n-2));
    }
}
