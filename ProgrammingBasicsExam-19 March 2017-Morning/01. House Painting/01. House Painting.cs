using System;

class Program
{
    static void Main()
    {
        double houseHeight = double.Parse(Console.ReadLine());
        double wallLenght = double.Parse(Console.ReadLine());
        double roofHeight = double.Parse(Console.ReadLine());

        //Walls
        var wall = houseHeight * wallLenght;
        var window = 1.5 * 1.5;
        var wallsLeftRight = 2 * wall - 2 * window;
        var wallBackFront = houseHeight * houseHeight;
        var door = 1.2 * 2;
        var totalFrontBack = 2 * wallBackFront - door;
        var totalBehindInFront = wallsLeftRight + totalFrontBack;
        var greenPaint = totalBehindInFront / 3.4;

        //Roof
        var rectangle2 = 2 * (houseHeight * wallLenght);
        var triangle2 = 2 * ((houseHeight * roofHeight) / 2);
        var totalRoof = rectangle2 + triangle2;
        var redPaint = totalRoof / 4.3;

        Console.WriteLine("{0:f2}", greenPaint);
        Console.WriteLine("{0:f2}", redPaint);
    }
}
