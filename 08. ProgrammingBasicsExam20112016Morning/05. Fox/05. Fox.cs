using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int rowLenght = 2 * n + 3;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(@"{0}\{1}/{0}", new string('*', i), new string('-', 2*n-i*2+1));
        }
        for (int i = 0; i < n/3; i++)
        {
            Console.WriteLine(@"|{0}\{1}/{0}|", new string('*',n/2+i), new string('*', n  - i*2));
        }
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(@"{0}\{1}/{0}", new string('-', i), new string('*', 2 * n - i * 2 + 1));
        }
    }
}
