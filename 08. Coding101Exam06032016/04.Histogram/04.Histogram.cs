using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number >= 1 && number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number <= 399){p2++;}
                else if (number >= 400 && number <= 599){p3++;}
                else if (number >= 600 && number <= 799){p4++;}
                else if (number >= 800){p5++;}
            }
            Console.WriteLine("{0:F2}%", p1 * 100.0 / n );
            Console.WriteLine("{0:F2}%", p2 * 100.0 / n );
            Console.WriteLine("{0:F2}%", p3 * 100.0 / n );
            Console.WriteLine("{0:F2}%", p4 * 100.0 / n );
            Console.WriteLine("{0:F2}%", p5 * 100.0 / n );
        }
    }
}
