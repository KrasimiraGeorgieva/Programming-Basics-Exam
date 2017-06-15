using System;
class TriangleArea
{
    static void Main()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        var x3 = double.Parse(Console.ReadLine());
        var y3 = double.Parse(Console.ReadLine());

        var a = Math.Abs(x2 - x3);
        var h = Math.Abs(y3 - y1);
        var S = a * h / 2.0;

        Console.WriteLine(S);
    }
}
