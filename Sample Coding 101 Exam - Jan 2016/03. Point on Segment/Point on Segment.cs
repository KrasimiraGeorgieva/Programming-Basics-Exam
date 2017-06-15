using System;
class Program
{
    static void Main()
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());
        var point = int.Parse(Console.ReadLine());

        var leftPoint = Math.Min(firstNum, secondNum);
        var rightPoint = Math.Max(firstNum, secondNum);

        var pointOnSegment =
            (point >= leftPoint) && (point <= rightPoint);

        var leftDistance = Math.Abs(point - leftPoint);
        var rightDistance = Math.Abs(point - rightPoint);
        var distance = Math.Min(leftDistance, rightDistance);

        if (pointOnSegment)
            Console.WriteLine("in");
        else
            Console.WriteLine("out");
        Console.WriteLine(distance);
    }
}
