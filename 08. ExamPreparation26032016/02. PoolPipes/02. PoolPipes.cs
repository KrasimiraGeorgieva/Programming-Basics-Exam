using System;
class PoolPipes
{
    static void Main()
    {
        double obem = double.Parse(Console.ReadLine());
        double debit1 = double.Parse(Console.ReadLine());
        double debit2 = double.Parse(Console.ReadLine());
        double hoursMiss = double.Parse(Console.ReadLine());

        debit1 *= hoursMiss;
        debit2 *= hoursMiss;
        double totalDebit = debit1 + debit2;
        double over = Math.Abs(obem - totalDebit);

        double fullPr = Math.Floor((totalDebit / obem) * 100.0);
        double fullP1 = Math.Floor((debit1 / totalDebit) * 100.0);
        double fullP2 = Math.Floor((debit2 / totalDebit) * 100.0);



        if (totalDebit <= obem)
        {
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", fullPr, fullP1, fullP2);
        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hoursMiss, over);
        }
    }
}
