using System;
class Program
{
    static void Main()
    {
        int ereaGrapes = int.Parse(Console.ReadLine());
        double grapesPerOneQuaterMeters = double.Parse(Console.ReadLine());
        int winesInLiters = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        var totalGrapes = ereaGrapes * grapesPerOneQuaterMeters;
        var totalWine = totalGrapes * 0.40 / 2.5;

        if (totalWine < winesInLiters)
        {
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(winesInLiters - totalWine));
        }

        else if (totalWine >= winesInLiters)
        {
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(totalWine));
            Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(totalWine - winesInLiters), Math.Ceiling
                ((totalWine - winesInLiters) / workers));
        }
    }
}
