using System;
class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine().ToLower();
        int NumberOfPeople = int.Parse(Console.ReadLine());

        double ticketPrice = 0.00;
        if (category == "vip")
            ticketPrice = 499.99;
        else if (category == "normal")
            ticketPrice = 249.99;

        var leftMoney = 0.00;
        if (NumberOfPeople >= 1 && NumberOfPeople <= 4)
        {
            leftMoney = budget - (budget*0.75);
            ticketPrice *= NumberOfPeople;
        }
        else if (NumberOfPeople >= 5 && NumberOfPeople <= 9)
        {
            leftMoney = budget - (budget * 0.60);
            ticketPrice *= NumberOfPeople;
        }
        else if (NumberOfPeople >= 10 && NumberOfPeople <= 24)
        {
            leftMoney = budget - (budget * 0.50);
            ticketPrice *= NumberOfPeople;
        }
        else if (NumberOfPeople >= 25 && NumberOfPeople <= 49)
        {
            leftMoney = budget - (budget * 0.40);
            ticketPrice *= NumberOfPeople;
        }
        else if (NumberOfPeople >= 55)
        {
            leftMoney = budget - (budget * 0.25);
            ticketPrice *= NumberOfPeople;
        }

        if(leftMoney >= ticketPrice)
        {
            Console.WriteLine("Yes! You have {0:F2} leva left.", leftMoney - ticketPrice);
        }
        else
        {
            Console.WriteLine("Not enough money! You need {0:F2} leva.",ticketPrice - leftMoney);
        }
    }
}
