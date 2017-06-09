using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // I variant
        for (int row = 1; row <= n; row++)
        {
            for (int col = 0; col < n - row; col++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (int col = 0; col < row - 1; col++)
            {
                Console.Write("-*");
            }
            Console.WriteLine();
        }

        for (int row = n - 1; row > 0; row--)
        {
            for (int col = 0; col < n - row; col++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (int col = 0; col < row - 1; col++)
            {
                Console.Write("-*");
            }
            Console.WriteLine();
        }


        // II variant
        //for (int row = 1; row <= n; row++)
        //{
        //    Console.Write(new string(' ', n - row));
        //    for (int col = 0; col < row - 1; col++)
        //    {
        //        Console.Write("*-");
        //    }
        //    Console.WriteLine("*");
        //}

        //for (int row = n - 1; row > 0; row--)
        //{
        //    Console.Write(new string(' ', n - row));
        //    for (int col = 0; col < row - 1; col++)
        //    {
        //        Console.Write("*-");
        //    }
        //    Console.WriteLine("*");
        //}
    }
}

