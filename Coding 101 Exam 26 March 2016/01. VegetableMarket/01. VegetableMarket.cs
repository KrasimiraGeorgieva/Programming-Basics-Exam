using System;
class VegetableMarket
{
    static void Main()
    {
        double vegKg = double.Parse(Console.ReadLine());
        double fruKg = double.Parse(Console.ReadLine());

        double TotalVegKg = double.Parse(Console.ReadLine());
        double TotalFruKg = double.Parse(Console.ReadLine());
        vegKg *= TotalVegKg;
        fruKg *= TotalFruKg;

        vegKg += fruKg;
        vegKg /= 1.94;
        Console.WriteLine(vegKg);


        // Console.WriteLine(((vegKg * TotalVegKg) + (fruKg * TotalFruKg))/ 1.94);

    }
}
