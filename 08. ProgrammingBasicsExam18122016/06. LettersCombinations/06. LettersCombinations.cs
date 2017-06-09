using System;
class Program
{
    static void Main()
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());
        char third = char.Parse(Console.ReadLine());
        int count = 0;
        for (char i = first; i <= second; i++)
        {
            for (char i1 = first; i1 <= second; i1++)
            {
                for (char i2 = first; i2 <= second; i2++)
                {
                    if (i != third && i1 != third && i2 != third)
                    {
                        Console.Write($"{i}{i1}{i2} ");
                        count++;
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}
