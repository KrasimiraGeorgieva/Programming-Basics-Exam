using System;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double dogFoodKg = double.Parse(Console.ReadLine());
            dogFoodKg *= days;
            double catFoodKg = double.Parse(Console.ReadLine());
            catFoodKg *= days;
            double turtleFoodKg = double.Parse(Console.ReadLine());
            turtleFoodKg = turtleFoodKg / 1000 * days;

            double totalFood = dogFoodKg + catFoodKg + turtleFoodKg;

            if (totalFood <= foodKg)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodKg-totalFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalFood-foodKg));
            }
        }
    }
}
