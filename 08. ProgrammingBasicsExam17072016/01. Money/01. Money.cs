using System;
class Program
{
    static void Main()
    {
        double bitcoins = double.Parse(Console.ReadLine());
        bitcoins *= 1168; //bitcoins in leva
        double iuan = Double.Parse(Console.ReadLine());
        iuan *= 0.15; //iuans in dollars
        iuan *= 1.76; //dollars in leva
        double commission = double.Parse(Console.ReadLine());

        double totalInLeva = bitcoins + iuan;
        totalInLeva /= 1.95; //leva in euro
        var result = totalInLeva - (totalInLeva * commission / 100);
        Console.WriteLine(result);
    }
}
