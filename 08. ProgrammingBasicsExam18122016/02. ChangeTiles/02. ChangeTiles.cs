using System;
class Program
{
    static void Main()
    {
        var money = double.Parse(Console.ReadLine());
        var flatW = double.Parse(Console.ReadLine());
        var flatL = double.Parse(Console.ReadLine());
        var sideTriangle = double.Parse(Console.ReadLine());
        var heightTriangle = double.Parse(Console.ReadLine());
        var pricePerTiles = double.Parse(Console.ReadLine());
        var workermanMoney = double.Parse(Console.ReadLine());

        var areaFlat = flatW * flatL;
        var areaTile = sideTriangle * heightTriangle/2;
        var neededTiles = Math.Ceiling(areaFlat / areaTile) + 5;
        var totalMoney = neededTiles * pricePerTiles + workermanMoney;

        if (totalMoney <= money)
        {
            Console.WriteLine("{0:f2} lv left.", money-totalMoney);
        }
        else
        {
            Console.WriteLine("You'll need {0:f2} lv more.", totalMoney-money);
        }
    }
}
