using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int halfRow = n - 2;


        for (int i = 1;
            i <= halfRow;
            i++)

            if (i % 2 == 0)
            {

                Console.WriteLine("{0}\\ /{0}", new string('-', halfRow));
            }
            else
            {
                Console.WriteLine("{0}\\ /{0}", new string('*', halfRow));
            }
        Console.WriteLine("{0}@{0}", new string(' ', halfRow + 1));

        for (int i = 1;
            i <= halfRow;
            i++)

            if (i % 2 == 0)
            {

                Console.WriteLine("{0}/ \\{0}", new string('-', halfRow));
            }
            else
            {
                Console.WriteLine("{0}/ \\{0}", new string('*', halfRow));
            }
    }
}
