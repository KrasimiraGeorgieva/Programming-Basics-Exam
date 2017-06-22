using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int lenght = 3 * n + 1;
        Console.WriteLine("+{0}+{1}", new string('~', n - 2), new string('.', 2 * n + 1));

        for (int i = 0; i <= 2 * n; i++)
        {
            Console.WriteLine("|{0}\\{1}\\{2}", new string('.', i), new string('~', n - 2), new string('.', lenght - 3 - i - (n - 2)));
        }

        for (int i = 0; i <= 2 * n; i++)
        {
            Console.WriteLine("{0}\\{1}|{2}|", new string('.', i), new string('.', lenght - 3 - i - (n - 2)), new string('~', n - 2));
        }


        Console.WriteLine("{0}+{1}+", new string('.', 2 * n + 1), new string('~', n - 2));
    }
}
