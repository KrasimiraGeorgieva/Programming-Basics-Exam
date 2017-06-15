using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            //Variant 1 
            for (int digits1 = 1; digits1 < n; digits1++)
            {
                for (int digits2 = 1; digits2 < n; digits2++)
                {
                    for (int letter3 = 0; letter3 < l; letter3++)
                    {
                        for (int letter4 = 0; letter4 < l; letter4++)
                        {
                            for (int digits5 = Math.Max(digits1, digits2) + 1;
                                digits5 < 1 + n;
                                digits5++)
                            {
                                Console.Write("" + digits1 + digits2
                                    + (char)(letter3 +'a') 
                                    + (char)(letter4 + 'a')
                                    + digits5 + " ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();



            //Variant 2
            //for (char i1 = '1'; i1 < '1' + n; i1++)
            //{
            //    for (char i2 = '1'; i2 <'1'+ n; i2++)
            //    {
            //        for (char i3 = 'a'; i3 <'a' + l; i3++)
            //        {
            //            for (char i4 = 'a'; i4 < 'a' + l; i4++)
            //            {
            //                for (char i5 = (char)(Math.Max(i1,i2) + 1); 
            //                    i5 <'1'+ n; 
            //                    i5++)
            //                {
            //                    Console.Write(""+i1+i2+i3+i4+i5+" ");
            //                }
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine();
        }
    }
}
