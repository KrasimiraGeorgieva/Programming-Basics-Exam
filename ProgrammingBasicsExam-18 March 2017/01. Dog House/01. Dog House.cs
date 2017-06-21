using System;

class Program
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double heightB = double.Parse(Console.ReadLine());

        var leftRightSides = sideA * (sideA / 2) * 2;
        var backSide = ((sideA / 2) * (sideA / 2)) + ((sideA / 2) * (heightB - sideA / 2)) / 2;
        var door = (sideA / 5) * (sideA / 5);
        var frontSide = backSide - door;
        var totalSides = leftRightSides + backSide + frontSide;
        var greenPaint = totalSides / 3;

        var roof = sideA * (sideA / 2) * 2;
        var redPaint = roof / 5;

        Console.WriteLine("{0:f2}", greenPaint);
        Console.WriteLine("{0:f2}", redPaint);
    }
}
