using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rowLenght = 2 * n;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n/2), new string('_', (rowLenght-4)-n/2*2));

            for (int i = 0; i < n-2-1; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', rowLenght-2));
            }

            Console.WriteLine("|{0}{1}{0}|", new string(' ', n/2+1), new string('_', (rowLenght - 4) - n / 2 * 2));

            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n/2), new string(' ', (rowLenght - 4) - n / 2 * 2));
        }
    }
}
