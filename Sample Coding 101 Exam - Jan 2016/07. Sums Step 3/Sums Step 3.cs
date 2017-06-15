using System;
class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        //Вариант: с масив от 3 числа.
        //var sums = new int[3];
        //for (int i = 0; i < n; i++)
        //{
        //    sums[i % 3] += int.Parse(Console.ReadLine());
        //}
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine(" sum{0} = {1}", i + 1, sums[i]);
        //}

        //Вариант: с % 3 
        var sum1 = 0;
        var sum2 = 0;
        var sum3 = 0;
        for (int i = 0; i < n; i++)
        {
            var num = int.Parse(Console.ReadLine());
            if (i % 3 == 0)
                sum1 += num;
            if (i % 3 == 1)
                sum2 += num;
            if (i % 3 == 2)
                sum3 += num;
        }
        Console.WriteLine("sum1 = {0}", sum1);
        Console.WriteLine("sum2 = {0}", sum2);
        Console.WriteLine("sum3 = {0}", sum3);
    }
}
