using System;
class Program
{
    static void Main()
    {
        int magicNum = int.Parse(Console.ReadLine());

        for (int number = 100000; number <= 999999; number++)
        {
            var digits = number;
            var product = 1;

            while (digits != 0)
            {
                var lastDigits = digits % 10;
                product *= lastDigits;
                digits /= 10;
            }
            if (product == magicNum)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
}
