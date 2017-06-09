using System;

class Program
{
    static void Main()
    {
        int workingDaysInMonth = int.Parse(Console.ReadLine());
        double MoneyPerDay = double.Parse(Console.ReadLine());
        double dollarsToBgn = double.Parse(Console.ReadLine());

        var salary = workingDaysInMonth * MoneyPerDay;
        var yearIncome = (salary * 12) + (salary * 2.5);
        var tax = yearIncome * 0.25;
        var netYearIncime = (yearIncome - tax) * dollarsToBgn;

        Console.WriteLine("{0:f2}", netYearIncime/365 );
    }
}
