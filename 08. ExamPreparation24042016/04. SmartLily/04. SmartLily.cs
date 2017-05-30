using System;

class SmartLily
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double priceWashingMashine = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        int money = 0;
        int toys = 0;
        var count = 0;
        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                money += i * 10 / 2;
                money -= 1;
                count++; ;
            }
            else
            {
                toys++;
            }
        }

        toys *= toyPrice;
        var allMoney = money + toys;

        if (allMoney >= priceWashingMashine)
        {
            Console.WriteLine("Yes! {0:F2}", allMoney - priceWashingMashine);
        }
        else
        {
            Console.WriteLine("No! {0:F}", Math.Abs(allMoney - priceWashingMashine));
        }
    }
}
