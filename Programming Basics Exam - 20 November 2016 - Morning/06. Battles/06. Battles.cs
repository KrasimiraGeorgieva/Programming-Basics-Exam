using System;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonsPlayer1 = int.Parse(Console.ReadLine());
            int pokemonsPlayer2 = int.Parse(Console.ReadLine());
            int numBattles = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 1; i <= pokemonsPlayer1; i++)
            {
                for (int y = 1; y <= pokemonsPlayer2; y++)
                {
                    if (count == numBattles)
                    {
                        break;
                    }
                    Console.Write("({0} <-> {1}) ",i,y);
                    count++;
                }
            }
            Console.WriteLine();
        }
    }
}
