using System;
class Program
{
    static void Main()
    {
        int numTovar = int.Parse(Console.ReadLine());
        int microbusTona = 0;
        double microbusLvTon = 200;
        int kamionTona = 0;
        double kamionLvTon = 175;
        int vlakTona = 0;
        double vlakLvTon = 120;

        for (int i = 0; i < numTovar; i++)
        {
            var tonaTovar = int.Parse(Console.ReadLine());
            if (tonaTovar <= 3)
            {
                microbusTona += tonaTovar;

            }
            else if (tonaTovar >= 4 && tonaTovar <= 11)
            {
                kamionTona += tonaTovar;
            }
            else if (tonaTovar >= 12)
            {
                vlakTona += tonaTovar;
            }
        }
        int totalTona = microbusTona + kamionTona + vlakTona;
        var srednoZaTon = (microbusTona * microbusLvTon + kamionTona * kamionLvTon + vlakTona * vlakLvTon)/totalTona;

        Console.WriteLine("{0:f2}", srednoZaTon);
        Console.WriteLine("{0:f2}%", (microbusTona * 100.0 / totalTona));
        Console.WriteLine("{0:f2}%", (kamionTona * 100.0 / totalTona));
        Console.WriteLine("{0:f2}%", (vlakTona * 100.0 / totalTona));
    }
}
