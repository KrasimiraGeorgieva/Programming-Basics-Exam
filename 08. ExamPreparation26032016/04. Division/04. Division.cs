using System;
class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double p1 = 0.00;
        double p2 = 0.00;
        double p3 = 0.00;

        for (double i = 1;
            i <= n;
            i++)
        {
            double countNum = double.Parse(Console.ReadLine());
            if (countNum % 2 == 0)
            {
                p1++;
            }
            if (countNum % 3 == 0)
            {
                p2++;
            }
            if (countNum % 4 == 0)
            {
                p3++;
            }
        }
        Console.WriteLine("{0:F2}%", p1 / n * 100);
        Console.WriteLine("{0:F2}%", p2 / n * 100);
        Console.WriteLine("{0:F2}%", p3 / n * 100);
    }
}
