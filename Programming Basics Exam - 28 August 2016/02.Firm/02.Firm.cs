using System;

class Program
{
    static void Main()
    {
        int neededHours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int numWorkers = int.Parse(Console.ReadLine());
        numWorkers *= 2 * days;
        double workingHours = 8 * (days - (days * 0.10));

        double totalHours = Math.Floor(workingHours + numWorkers);

        if (totalHours >= neededHours)
        {
            Console.WriteLine("Yes!{0} hours left.", totalHours - neededHours);
        }
        else
        {
            Console.WriteLine("Not enough time!{0} hours needed.", neededHours - totalHours);
        }
    }
}
