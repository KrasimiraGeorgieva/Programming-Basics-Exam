using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //I variant
        Console.WriteLine(new string('%', 2 * n));
        var rows = n;
        if (n % 2 == 0)
        {
            rows = n - 1;
        }
        for (int i = 1; i <= rows; i++)
        {
            if (i == (rows + 1) / 2)
            {
                Console.WriteLine("%{0}**{0}%", new string(' ', n - 2));
            }
            else
            {
                Console.WriteLine("%{0}%", new string(' ', 2 * n - 2));
            }
        }
        Console.WriteLine(new string('%', 2 * n));

        //II variant
        //Console.WriteLine(new string('%', n * 2));
        //int numRows = n - 1;
        //if (n % 2 == 1)
        //{
        //    numRows++;
        //}
        //for (int i = 0; i < numRows; i++)
        //{
        //    Console.Write("%");
        //    Console.Write(new string(' ', n - 2));
        //    if (i == numRows / 2)
        //    {
        //        Console.Write("**");
        //    }
        //    else
        //    {
        //        Console.Write("  ");
        //    }
        //    Console.Write(new string(' ', n - 2));
        //    Console.Write("%");
        //    Console.WriteLine();
        //}
        //Console.WriteLine(new string('%', n * 2));
    }
}
