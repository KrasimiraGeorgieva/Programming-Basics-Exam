using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            var examTotalMins = examHour * 60 + examMinute;
            var arriveTotalMins = arriveHour * 60 + arriveMinute;
            var minutesDifference = arriveTotalMins - examTotalMins;

            string word = "before"; //after or before
            string minsOrHours = "minutes";
            string time;

            if (minutesDifference > 0)
            {
                Console.WriteLine("Late");
                word = "after";
            }
            else if (minutesDifference >= -30 && minutesDifference <= 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Early");
            }
            var resultHours = Math.Abs(minutesDifference / 60);
            var resultMins = Math.Abs(minutesDifference % 60);

            if (resultHours > 0)
            {
                minsOrHours = "hours";
                time = string.Format("{0}:{1}", resultHours, resultMins.ToString().PadLeft(2, '0'));
            }
            else
            {
                time = resultMins.ToString();
            }

            Console.WriteLine("{0} {1} {2} the start", time, minsOrHours, word);
        }
    }
}
