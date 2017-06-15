using System;
class Program
{
    static void Main()
    {
        int numStudent = int.Parse(Console.ReadLine());

        var topGrade = 0;
        var between45 = 0;
        var between34 = 0;
        var failGrade = 0;
        var averageGrade = 0.0;
        

        for (int i = 0; i < numStudent; i++)
        {
            double grate = double.Parse(Console.ReadLine());
            if (grate >= 5)
            {
                topGrade++;
            }
            if(grate<=4.99 && grate >= 4.00)
            {
                between45++;
            }
            if(grate<=3.99 && grate >= 3.00)
            {
                between34++;
            }
            if (grate < 3)
            {
                failGrade++;
            }
            averageGrade += grate;
        }
        Console.WriteLine("Top students: {0:f2}%",topGrade * 100.0/ numStudent);
        Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", between45 * 100.0 / numStudent);
        Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", between34 * 100.0 / numStudent);
        Console.WriteLine("Fail: {0:f2}%", failGrade * 100.0 / numStudent);
        Console.WriteLine("Average: {0:f2}", averageGrade/numStudent);
    }
}
