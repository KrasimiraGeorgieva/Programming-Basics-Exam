using System;

class Program
{
    static void Main()
    {
        int glassesNums = int.Parse(Console.ReadLine());
        int workersNums = int.Parse(Console.ReadLine());
        int workingDays = int.Parse(Console.ReadLine());

        var workingHours = workersNums * workingDays * 8;
        var glassesMade = Math.Floor(workingHours / 5.0);

        var difference = Math.Abs(glassesNums - glassesMade);

        if (glassesNums < glassesMade)
        {
            Console.WriteLine("{0:f2} extra money", (difference * 4.2));
        }
        else if(glassesMade < glassesNums)
        {
            Console.WriteLine("Losses: {0:f2}", (difference * 4.2));
        }
    }
}
