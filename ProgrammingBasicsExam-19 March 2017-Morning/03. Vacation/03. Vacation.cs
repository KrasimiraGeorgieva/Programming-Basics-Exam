using System;

class Program
{
    static void Main()
    {
        var budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        var price = 0.0;
        var location = string.Empty;//Alaska,Morocco
        var accommodation = string.Empty;//Hotel/Hut/Camp

        if (budget <= 1000)
        {
            accommodation = "Camp";
            if(season == "Summer")
            {
                location = "Alaska";
                price = 0.65 * budget;
            }
            else
            {
                location = "Morocco";
                price = 0.45 * budget;
            }
        }

        else if(budget > 1000 && budget <= 3000)
        {
            accommodation = "Hut";
            if (season == "Summer")
            {
                location = "Alaska";
                price = 0.80 * budget;
            }
            else
            {
                location = "Morocco";
                price = 0.60 * budget;
            }
        }
        else if (budget > 3000)
        {
            accommodation = "Hotel";
            price = 0.90 * budget;
            if (season == "Summer")
            {
                location = "Alaska";
            }
            else
            {
                location = "Morocco";
            }
        }
        Console.WriteLine("{0} - {1} - {2:f2}", location, accommodation, price);
    }
}
