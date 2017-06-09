using System;
class Program
{
    static void Main()
    {
        int juniorsNum = int.Parse(Console.ReadLine());
        int seniorsNum = int.Parse(Console.ReadLine());
        string layout = Console.ReadLine().ToLower();

        var totalSum = 0.00;

        if (layout == "trail")
        {
            totalSum = juniorsNum * 5.50 + seniorsNum * 7;
        }
        else if (layout == "cross-country")
        {
            if ((juniorsNum + seniorsNum) >= 50)
            {
                totalSum = juniorsNum * 8 + seniorsNum * 9.50;
                totalSum = totalSum - (totalSum * 0.25);
            }
            else
            {
                totalSum = juniorsNum * 8 + seniorsNum * 9.50;
            }
        }
        else if (layout == "downhill")
        {
            totalSum = juniorsNum * 12.25 + seniorsNum * 13.75;
        }
        else if (layout == "road")
        {
            totalSum = juniorsNum * 20 + seniorsNum * 21.50;
        }

        var expenses = totalSum * 0.05;

        Console.WriteLine("{0:f2}", Math.Abs(totalSum - expenses));
    }
}
