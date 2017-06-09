using System;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupNum = int.Parse(Console.ReadLine());

            int peopleNumInGroup=0;
            int carPeople = 0;
            int minibusPeople = 0;
            int smallBusPeople = 0;
            int bigBusPeople = 0;
            int trainPeople = 0;
            int totalPeople = 0;

            for (int i = 1; i <= groupNum; i++)
            {
                peopleNumInGroup = int.Parse(Console.ReadLine());
                totalPeople += peopleNumInGroup;
                if (peopleNumInGroup <= 5)
                {
                    carPeople += peopleNumInGroup;
                }
                else if (peopleNumInGroup >= 6 && peopleNumInGroup <= 12)
                {
                    minibusPeople += peopleNumInGroup;
                }
                else if (peopleNumInGroup >= 13 && peopleNumInGroup <= 25)
                {
                    smallBusPeople += peopleNumInGroup;
                }
                else if (peopleNumInGroup >= 26 && peopleNumInGroup <= 40)
                {
                    bigBusPeople += peopleNumInGroup;
                }
                else if (peopleNumInGroup >= 41)
                {
                    trainPeople += peopleNumInGroup;
                }
            }
            var result = totalPeople / 100.0;
            Console.WriteLine("{0:F2}%", carPeople / result);
            Console.WriteLine("{0:F2}%", minibusPeople / result);
            Console.WriteLine("{0:F2}%", smallBusPeople / result);
            Console.WriteLine("{0:F2}%", bigBusPeople /result);
            Console.WriteLine("{0:F2}%", trainPeople / result);
        }
    }
}
