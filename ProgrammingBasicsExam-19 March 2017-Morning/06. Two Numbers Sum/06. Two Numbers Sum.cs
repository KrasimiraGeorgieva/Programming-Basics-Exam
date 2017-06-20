using System;

class Program
{
    static void Main()
    {
        int begining = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int magicNum = int.Parse(Console.ReadLine());

        var count = 0;

        for (int num1 = begining; num1 >= end; num1--)
        {
            for (int num2 = begining; num2 >= end; num2--)
            {
                count++;
                if (num1 + num2 == magicNum)
                {
                    Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", count, num1, num2, magicNum);
                    return;
                }
            }
        }
        Console.WriteLine("{0} combinations - neither equals {1}", count, magicNum);
    }
}
