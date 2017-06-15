using System;
class Program
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int brKomdo = int.Parse(Console.ReadLine());

        var count = 0;
        for (int i = n1; i <= n2; i++)
        {
            for (int i1 = n1; i1 <= n2; i1++)
            {
                if (count == brKomdo)
                {
                    break;
                }

                Console.Write("<{0}-{1}>", i, i1);
                count++;
            }
        }
        Console.WriteLine();
    }
}
