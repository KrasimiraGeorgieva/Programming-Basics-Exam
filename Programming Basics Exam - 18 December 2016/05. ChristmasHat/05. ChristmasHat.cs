using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var rowLenght = 4 * n + 1;

        Console.WriteLine("{0}/|\\{0}", new string('.', (rowLenght - 3) / 2));
        Console.WriteLine("{0}\\|/{0}", new string('.', (rowLenght - 3) / 2));

        for (int i = 0; i <= n * 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', (rowLenght - 3 - 2 * i) / 2), new string('-', i));
        }
        Console.WriteLine(new string('*', 4 * n + 1));
        for (int i = 1; i <= 4 * n + 1; i++)
        {
            if (i % 2 == 0)
                Console.Write(".");
            else
                Console.Write("*");
        }
        Console.WriteLine();
        Console.WriteLine(new string('*', 4 * n + 1));
    }
}
