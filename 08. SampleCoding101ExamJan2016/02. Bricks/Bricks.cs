using System;
class Bricks
{
    static void Main()
    {
        //var bricks = int.Parse(Console.ReadLine());
        //var workers = int.Parse(Console.ReadLine());
        //var capacityTrolley = int.Parse(Console.ReadLine());

        //var bricksPerCourse = workers * capacityTrolley;
        //var coursesCount = (bricks + bricksPerCourse - 1) / bricksPerCourse;
        //Console.WriteLine(coursesCount);


        var bricks = double.Parse(Console.ReadLine());
        var workers = double.Parse(Console.ReadLine());
        var capacityTrolley = double.Parse(Console.ReadLine());

        var bricksPerCourse = workers * capacityTrolley;
        var coursesCount = Math.Ceiling(bricks / bricksPerCourse);
        Console.WriteLine(coursesCount);
    }
}
