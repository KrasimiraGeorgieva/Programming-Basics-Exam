using System;

class SleepyCatTom
{
    static void Main()
    {
        int numHolidays = int.Parse(Console.ReadLine());
        int workDays = (365 - numHolidays) * 63;
        numHolidays *= 127;
        int minPlay = workDays + numHolidays;
        int result = Math.Abs(30000 - minPlay);

        if(minPlay > 30000)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", result / 60, result % 60);
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", result / 60, result % 60);
        }
    }
}