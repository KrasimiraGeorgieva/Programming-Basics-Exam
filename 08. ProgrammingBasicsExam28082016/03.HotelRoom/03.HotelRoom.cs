using System;

class Program
{
    static void Main()
    {
        string month = Console.ReadLine().ToLower();
        int numberNights = int.Parse(Console.ReadLine());

        var studioPrice = 0.0;
        var apartmantsPrice = 0.0;

        if (month == "may" || month == "october")
        {
            studioPrice = 50;
            apartmantsPrice = 65;
            if (numberNights > 7 && numberNights <= 14)
            {
                studioPrice = studioPrice - (studioPrice * 0.05);
            }
            if (numberNights > 14)
            {
                studioPrice -= studioPrice * 0.30;
            }
        }

        if (month == "june" || month == "september")
        {
            studioPrice = 75.20;
            apartmantsPrice = 68.70;
            if (numberNights > 14)
            {
                studioPrice -= studioPrice * 0.20;
            }
        }

        if (month == "july" || month == "august")
        {
            studioPrice = 76;
            apartmantsPrice = 77;
        }

        if (numberNights > 14)
        {
            apartmantsPrice -= apartmantsPrice * 0.10;
        }

        Console.WriteLine("Apartment: {0:f2} lv.", apartmantsPrice * numberNights);
        Console.WriteLine("Studio: {0:f2} lv.", studioPrice * numberNights);
    }
}
