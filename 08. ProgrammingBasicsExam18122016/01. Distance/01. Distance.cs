using System;
class Program
{
    static void Main()
    {
        int speed = int.Parse(Console.ReadLine());
        double timeInMin1 = double.Parse(Console.ReadLine());
        timeInMin1 /= 60.00;
        double timeInMin2 = double.Parse(Console.ReadLine());
        timeInMin2 /= 60.00;
        double timeInMin3 = double.Parse(Console.ReadLine());
        timeInMin3 /= 60.00;

        var distance = speed * timeInMin1;
        var distanceUp = (speed + (speed * 0.10)) * timeInMin2;
        var distanceDown = ((speed + (speed * 0.10)) - ((speed + (speed * 0.10)) * 0.05)) * timeInMin3;
        var totalDistance = distance + distanceUp + distanceDown;
        Console.WriteLine("{0:f2}",totalDistance);
    }
}
