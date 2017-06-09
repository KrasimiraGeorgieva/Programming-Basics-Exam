using System;
class Program
{
    static void Main()
    {
        var x = int.Parse(Console.ReadLine());
        var y = int.Parse(Console.ReadLine());

        var insideLeftRect =
            (x >= 2) && (x <= 12) &&
            (y >= -3) && (y <= 1);
        var insideRightRect =
            (x >= 4) && (x <= 10) &&
            (y >= -5) && (y <= 3);

        if 
            (insideLeftRect || insideRightRect)
            Console.WriteLine("in");
        else
            Console.WriteLine("out");
    }
}
