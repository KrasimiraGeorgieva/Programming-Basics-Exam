using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int rowLength = 12 * n - 5;

        Console.WriteLine("{0}#{0}", new string('.', (rowLength-1)/2));

        for (int i = 1; i <= n*2-2; i++)
        {            
            Console.WriteLine("{0}{1}{0}", new string('.', rowLength / 2 - 3*i), new string('#', 1 + 6*i));
        }

        Console.WriteLine("{0}", new string('#', rowLength));

        for (int i = 1; i <= n-2; i++)
        {
            Console.WriteLine("|{0}{1}{2}", new string('.', 3 * i - 1), new string('#', rowLength - 6*i ), new string('.',  3 * i));
        }

        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("|{0}{1}{2}",new string('.', 3*n-4), new string('#', 6*n+1), new string('.', 3*n-4+1));
        }

        Console.WriteLine("@{0}{1}{2}", new string('.', 3 * n - 4), new string('#', 6 * n + 1), new string('.', 3 * n - 4 + 1));
    }
}
