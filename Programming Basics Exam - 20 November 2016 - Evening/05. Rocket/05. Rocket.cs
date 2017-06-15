using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int wCol = 3 * n;
        int help = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}/{1}\\{0} ", new string('.', (wCol - 2 - help) / 2), new string(' ', help));
            help += 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', 2 * n));

        for (int t = 0; t < 2 * n; t++)
        {
            Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', n * 2 - 2));
        }
        for (int b = n / 2; b > 0; b--)
        {
            Console.WriteLine("{0}/{1}\\{0}", new string('.', b), new string('*', (wCol - 2 * b) - 2));
        }
    }
}
