using System;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());

            double palamudPrice = skumriaPrice + skumriaPrice * 0.60;
            double safridPrice = cacaPrice + cacaPrice * 0.80;
            double midiPrice = 7.50;

            double palamud = palamudKg * palamudPrice;
            double safrid = safridKg * safridPrice;
            double midi = midiKg * midiPrice;

            Console.WriteLine("{0:f2}", palamud+safrid+midi);
         }
    }
}

