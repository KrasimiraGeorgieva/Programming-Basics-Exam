using System;

class TileRepairment
{
    static void Main()
    {
        double N = double.Parse(Console.ReadLine());
        N *= N; // обща площ площадка
        double W = double.Parse(Console.ReadLine());
        double L = double.Parse(Console.ReadLine());
        L *= W; // площ на плочките
        double M = double.Parse(Console.ReadLine());
        double O = double.Parse(Console.ReadLine());
        M *= O; // площ на пейката
        N -= M;
        N /= L;
        Console.WriteLine(N);
        N *= 0.2;
        Console.WriteLine(N);
    }
}
//ВХОД
//•	N – дължината на страна от площадката в интервала[1...100]
//•	W – широчината на една плочка в интервала[0.1...10.00]
//•	L – дължината на една плочка в интервала[0.1...10.00]
//•	М – широчината на пейката в интервала[0...10]
//•	О – дължината на пейката в интервала[0...10]
//ИЗХОД
//Обща площ = 20 * 20 = 400; площ на пейката = 1 * 2 = 2
//Площ за покриване = 400 – 2 = 398
//Площ на плочки = 5 * 4 = 20
//Необходими плочки = 398 / 20 = 19.9
//Необходимо време = 19.9 * 0.2 = 3.98
