using System;
class Trip
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        var season = Console.ReadLine();

        var place = string.Empty;//Bulgaria/Balkans/Europa
        var accomodation = string.Empty;
        var amount = 0.0;
        if (budget<= 100)
        {
            place = "Bulgaria";
            if(season == "summer")
            {
                accomodation = "Camp";
                amount = 0.30 * budget;
            }
            else
            {
                accomodation = "Hotel";
                amount = 0.70 * budget;
            }
        }
        else if(budget <= 1000)
        {
            place = "Balkans";
            if (season == "summer")
            {
                accomodation = "Camp";
                amount = 0.40 * budget;
            }
            else
            {
                accomodation = "Hotel";
                amount = 0.80 * budget;
            }
        }
        else
        {
            place = "Europe";
            accomodation = "Hotel";
            amount = 0.90 * budget;
        }
        Console.WriteLine("Somewhere in {0}", place);
        Console.WriteLine("{0} - {1:F2}", accomodation, amount);

    }
}
