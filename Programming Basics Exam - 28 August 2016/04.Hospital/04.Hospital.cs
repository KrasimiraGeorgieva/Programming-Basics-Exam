using System;

class Program
{
    static void Main()
    {
        int period = int.Parse(Console.ReadLine());

        int pazien = 0;
        int pregledani = 0;
        int nePregledani = 0;
        int brLekari = 7;

        for (int i = 1; i <= period; i++)
        {
            var den = i;
            pazien = int.Parse(Console.ReadLine());

            if (den % 3 == 0 && nePregledani > pregledani)
            {
                brLekari++;
            }

            if (pazien > 7)
            {
                pregledani += brLekari;
                nePregledani += pazien - brLekari;
            }

            else
            {
                pregledani += pazien;
            }
        }
        Console.WriteLine("Treated patients: {0}.", pregledani);
        Console.WriteLine("Untreated patients: {0}.", nePregledani);
    }
}
