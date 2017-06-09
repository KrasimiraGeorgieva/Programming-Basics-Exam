using System;
class Program
{
    static void Main()
    {
        //Variant 1
        double money = double.Parse(Console.ReadLine());
        int yearToLive = int.Parse(Console.ReadLine());

        var age = 18;
        for (int i = 1800; i <= yearToLive; i++)
        {

            if (i % 2 == 0)
            {
                money -= 12000;
            }
            else
            {
                money -= 12000.00 + 50 * age;
            }
            age++;
        }
        if (money < 0)
        {
            Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(money));
        }
        else
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", money);
        }

        // Variant 2
        //int ivanchoAge = 18;
        //var inheritedMoney = double.Parse(Console.ReadLine());
        //var funeralYear = int.Parse(Console.ReadLine());
        //double neededMoney = 0.00;
        //int startYear = 1800;
        //int iterationYear = startYear;

        //do
        //{
        //    if (iterationYear % 2 == 0)
        //        neededMoney += 12000;
        //    if (iterationYear % 2 != 0)
        //        neededMoney += 12000 + 50 * ivanchoAge;

        //    iterationYear++;
        //    ivanchoAge++;
        //}
        //while (iterationYear <= funeralYear);

        //if (neededMoney <= inheritedMoney)
        //{
        //    Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", inheritedMoney - neededMoney);
        //}

        //if (neededMoney > inheritedMoney)
        //{
        //    Console.WriteLine("He will need {0:f2} dollars to survive. ", neededMoney - inheritedMoney);
        //}




        // Variant 1
        //double money = double.Parse(Console.ReadLine());
        //int yearToLive = int.Parse(Console.ReadLine());

        //var age = 18;
        //for (int i = 1800; i <= yearToLive; i++)
        //{

        //    if (i % 2 == 0)
        //    {
        //        money -= 12000;
        //    }
        //    else
        //    {
        //        money -= 12000.00 + 50 * age;
        //    }
        //    age++;
        //}
        //if (money < 0)
        //{
        //    Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(money));
        //}
        //else
        //{
        //    Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", money);
        //}

        // Variant 2
        //int ivanchoAge = 18;
        //var inheritedMoney = double.Parse(Console.ReadLine());
        //var funeralYear = int.Parse(Console.ReadLine());
        //double neededMoney = 0.00;
        //int startYear = 1800;
        //int iterationYear = startYear;

        //do
        //{
        //    if (iterationYear % 2 == 0)
        //        neededMoney += 12000;
        //    if (iterationYear % 2 != 0)
        //        neededMoney += 12000 + 50 * ivanchoAge;

        //    iterationYear++;
        //    ivanchoAge++;
        //}
        //while (iterationYear <= funeralYear);

        //if (neededMoney <= inheritedMoney)
        //{
        //    Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", inheritedMoney - neededMoney);
        //}

        //if (neededMoney > inheritedMoney)
        //{
        //    Console.WriteLine("He will need {0:f2} dollars to survive. ", neededMoney - inheritedMoney);
        //}



        //Variant 3
        //double money = double.Parse(Console.ReadLine());
        //double yearTo = double.Parse(Console.ReadLine());

        //double moneyFinal = money;
        //double counter = 0;
        //for (int i = 1800; i <= yearTo; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        moneyFinal = moneyFinal - 12000;
        //        counter += 12000;
        //    }

        //    else if (i % 2 == 1)
        //    {
        //        moneyFinal = moneyFinal - 12000 - (50 * ((i + 18) - 1800));
        //        counter += 12000 + (50 * ((i + 18) - 1800));
        //    }
        //}

        //double sum = Math.Abs(moneyFinal);

        //if (money >= counter)
        //{

        //    Console.WriteLine($"Yes! He will live a carefree life and will have {sum:0.00} dollars left.");
        //}
        //else
        //{
        //    Console.WriteLine($"He will need {sum:0.00} dollars to survive.");

        //}
    }
}

    
