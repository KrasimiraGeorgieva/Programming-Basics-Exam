﻿using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int one = 1; one < 10; one++)
        {
            for (int two = 1; two < 10; two++)
            {
                for (int three = 1; three < 10; three++)
                {
                    for (int four = 1; four < 10; four++)
                    {
                        if (n % one == 0 && n % two == 0 && n % three == 0 && n % four == 0)
                        {
                            Console.Write($"{one}{two}{three}{four} ");
                        }
                    }
                }
            }
        }
        Console.WriteLine();
    }
}
