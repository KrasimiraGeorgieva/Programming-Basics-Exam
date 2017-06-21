using System;

class Program
{
    static void Main()
    {
        int neededHours = int.Parse(Console.ReadLine());
        int workermenNum = int.Parse(Console.ReadLine());
        int workingDays = int.Parse(Console.ReadLine());

        int totalWorkingHours = workermenNum * workingDays * 8;

        if (totalWorkingHours > neededHours)
        {
            Console.WriteLine("{0} hours left", totalWorkingHours -neededHours);
        }
        else
        {
            Console.WriteLine("{0} overtime", neededHours - totalWorkingHours);
            Console.WriteLine("Penalties: {0}", (neededHours-totalWorkingHours)*workingDays);
        }
    }
}
