using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minArea = int.Parse(Console.ReadLine());

            //var printNo = true;
            var count = 0;
            for (var left = -n; left <= n; left++)
            {
                for (var top = -n; top <= n; top++)
                {
                    for (var right = left + 1; right <= n; right++)
                    {
                        for (var bottom = top + 1; bottom <= n; bottom++)
                        {
                            var width = right - left;
                            var height = bottom - top;
                            var area = width * height;
                            if (area >= minArea)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                                //printNo = false;
                                count++;
                            }
                        }
                    }
                }
            }
            //if (printNo)
            if(count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
