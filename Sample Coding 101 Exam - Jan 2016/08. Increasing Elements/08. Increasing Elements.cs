using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //if (n == 0)
        //{
        //    Console.WriteLine(0);
        //    return;
        //}

        var maxLenght = 0;
        var currentLenght = 0;
        var previousNumber = 0;

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if((i == 0) || (currentNumber > previousNumber))
            {
                currentLenght++;
            }
            else
            {
                currentLenght = 1;
            }
            if (currentLenght > maxLenght)
            {
                maxLenght = currentLenght;
            }
            previousNumber = currentNumber;
        }
        Console.WriteLine(maxLenght);
    }
}
