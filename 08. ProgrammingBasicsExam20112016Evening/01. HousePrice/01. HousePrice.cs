using System;
class Program
{
    static void Main()
    {
        double smallestRoomArea = double.Parse(Console.ReadLine());
        double kitchenArea = double.Parse(Console.ReadLine());
        double priceKvM = double.Parse(Console.ReadLine());

        var secondRoom = smallestRoomArea + (smallestRoomArea * 0.10);
        var thirdRoom = secondRoom + (secondRoom * 0.10);
        var bathroom = smallestRoomArea / 2;
        var totalArea = smallestRoomArea + kitchenArea + secondRoom + thirdRoom + bathroom;
        totalArea = totalArea + (totalArea * 0.05);

        Console.WriteLine("{0:f2}", totalArea*priceKvM);
    }
}
