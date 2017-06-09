using System;
class Program
{
    static void Main()
    {
        var day = int.Parse(Console.ReadLine());
        var month = int.Parse(Console.ReadLine());


        var dayInTheMonth = 31;
        if (month == 4 || month == 6 || month == 9 || month == 11)
            dayInTheMonth = 30;
        else if (month == 2)
            dayInTheMonth = 28;
        
        day = day + 5;
        if (day > dayInTheMonth)
        {
            day = day - dayInTheMonth;
            month++;
            // month = (month - ) % 12 + 1; - втори вариант
            if (month == 13)
            {
                month = 1;
            }
        }
        if (month < 10)
            Console.WriteLine("{0}.0{1}", day, month);
        else
            Console.WriteLine("{0}.{1}", day, month);
    }
}
