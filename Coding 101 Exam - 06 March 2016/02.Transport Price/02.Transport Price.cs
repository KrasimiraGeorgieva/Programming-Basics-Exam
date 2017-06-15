using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variant 1
            int km = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            double startTaxiPrice = 0.7;
            double taxiPrice = 0;
            double busPrice = int.MaxValue;
            double trainPrice = int.MaxValue;

            if (timeOfDay == "day")
            {
                taxiPrice = startTaxiPrice + (km * 0.79);
            }
            else
            {
                taxiPrice = startTaxiPrice + (km * 0.9);

            }

            if (km >= 20)
            {
                busPrice = 0.09 * km;
            }

            if (km >= 100)
            {
                trainPrice = 0.06 * km;
            }

            Console.WriteLine(Math.Min(Math.Min(taxiPrice, busPrice), trainPrice));

            // Variant 2
            //int km = int.Parse(Console.ReadLine());
            //string dayNight = Console.ReadLine().ToLower();

            //var taxiPrice = 0.0;
            //if (dayNight == "day")
            //{
            //    taxiPrice = 0.70 + (km * 0.79);
            //}
            //else
            //{
            //    taxiPrice = 0.70 + (km * 0.90);
            //}
            //var busPrice = km * 0.09;
            //var trainPrice = km * 0.06;

            //if (km < 20)
            //{
            //    Console.WriteLine(taxiPrice);
            //}
            //if (km >= 20 && km < 100)
            //{
            //    Console.WriteLine(busPrice);
            //}
            //if (km >= 100)
            //{
            //    Console.WriteLine(trainPrice);
            //}
        }
    }
}
