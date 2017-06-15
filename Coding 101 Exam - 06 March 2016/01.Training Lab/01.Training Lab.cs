using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double wInM = double.Parse(Console.ReadLine());
            var w = wInM * 100;
            double hInM = double.Parse(Console.ReadLine());
             var h = hInM * 100;

            h -= 100; // ширината без коридора
            h = (int)(h / 70);     //бюра на ред
            w = (int)(w / 120);    //реда
            var brMesta = w * h - 3;

            Console.WriteLine("{0}",brMesta);
        }
    }
}
