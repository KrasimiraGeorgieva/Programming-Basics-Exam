using System;
class Program
{
    static void Main()
    {
        int magnolii = int.Parse(Console.ReadLine());
        int ziumbiul = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int kaktusi = int.Parse(Console.ReadLine());
        double presentPrice = double.Parse(Console.ReadLine());

        var sum = magnolii * 3.25 + ziumbiul * 4 + roses * 3.50 + kaktusi * 8;
        var taxes = sum * 0.05;
        var profit = sum - taxes;

        if (presentPrice <= profit)
        {
            Console.WriteLine("She is left with {0} leva.", Math.Floor(profit-presentPrice));
        }
        else
        {
            Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(presentPrice-profit));
        }
    }
}
