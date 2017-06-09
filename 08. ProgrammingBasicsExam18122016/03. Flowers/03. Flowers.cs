using System;

class Program
{
    static void Main()
    {
        //Variant 1

        int hrizantemiNum = int.Parse(Console.ReadLine());
        int roziNum = int.Parse(Console.ReadLine());
        int laletaNum = int.Parse(Console.ReadLine());
        string sezon = Console.ReadLine().ToLower();
        char isItHoliday = char.Parse(Console.ReadLine().ToLower());

        var hrizantemiPrice = 0.0;
        var roziPrice = 0.0;
        var laletaPrice = 0.0;

        if (sezon == "spring" || sezon == "summer")
        {
            hrizantemiPrice = hrizantemiNum * 2.00;
            roziPrice = roziNum * 4.10;
            laletaPrice = laletaNum * 2.50;
        }
        if (sezon == "autumn" || sezon == "winter")
        {
            hrizantemiPrice = hrizantemiNum * 3.75;
            roziPrice = roziNum * 4.50;
            laletaPrice = laletaNum * 4.15;
        }
        double price = hrizantemiPrice + roziPrice + laletaPrice;

        if (isItHoliday == 'y')
        {
            price += (price * 0.15);
        }
        if (laletaNum > 7 && sezon == "spring")
        {
            price -= (price * 5 / 100);
        }
        if (roziNum >= 10 && sezon == "winter")
        {
            price -= (price * 0.10);
        }
        if (hrizantemiNum + roziNum + laletaNum > 20)
        {
            price -= (price * 0.20);
        }
        Console.WriteLine("{0:f2}", price + 2);
        
        


        //Variant 2
        //int hrizantemi = int.Parse(Console.ReadLine());
        //int rozi = int.Parse(Console.ReadLine());
        //int laleta = int.Parse(Console.ReadLine());
        //string season = Console.ReadLine().ToLower();
        //string isHolyday = Console.ReadLine().ToLower();
        //double hrizantemiPrice = 0;
        //double roziPrice = 0;
        //double laletaPrice = 0;
        //double totalPrice = 0;
        //int discount = 0;

        //switch (season)
        //{
        //    case "spring":
        //    case "summer":
        //        hrizantemiPrice = 2;
        //        roziPrice = 4.1;
        //        laletaPrice = 2.5;
        //        break;
        //    case "autumn":
        //    case "winter":
        //        hrizantemiPrice = 3.75;
        //        roziPrice = 4.50;
        //        laletaPrice = 4.15;
        //        break;
        //}
        //totalPrice = hrizantemi * hrizantemiPrice + rozi * roziPrice + laleta * laletaPrice; ;
        //if (isHolyday == "y")
        //{
        //    totalPrice *= 1.15;

        //}
        //if (season == "spring" && laleta > 7)
        //{
        //    discount += 5;
        //    totalPrice = totalPrice - ((totalPrice * discount) / 100);
        //}
        //if (season == "winter" && rozi >= 10)
        //{
        //    discount = 10;
        //    totalPrice = totalPrice - ((totalPrice * discount) / 100);
        //}
        //if (hrizantemi + rozi + laleta > 20)
        //{
        //    discount = 20;
        //    totalPrice = totalPrice - ((totalPrice * discount) / 100);
        //}

        //Console.WriteLine("{0:f2}", totalPrice + 2);
    }
}
