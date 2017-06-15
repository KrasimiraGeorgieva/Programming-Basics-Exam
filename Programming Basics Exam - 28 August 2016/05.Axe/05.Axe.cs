using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int rowLenght = 5 * n;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n), new string('-', i), new string('-', rowLenght - 2 - i - 3 * n));
        }
        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}*{2}", new string('*', 3 * n + 1), new string('-', n - 1), new string('-', n - 1));
        }
        int a = 0, b = 0, c = 0;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n +a), new string('-', n - 1 + b), new string('-', n -1 + c));
            a--;b += 2;c--;
        }

        int x = n / 2 - 1;
           Console.WriteLine("{0}*{1}*{2}", new string('-', (3 * n) - x), new string('*', n-1+(x*2)), new string('-', n-1-x));
    }
}

