using System;

class Stop
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int red = (2 * (n + 1) + ((2 * n) + 1));
        Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', (2 * n) + 1));
        for (int i = n; i > 0; i--)
        {
            Console.WriteLine("{0}//{1}\\\\{0}", new string('.', i), new string('_', (red - 2 * i) - 4));
        }
        Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (red - 9) / 2));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\\\{1}//{0}", new string('.', i), new string('_', (red - 2 * i) - 4));
        }
    }
}
