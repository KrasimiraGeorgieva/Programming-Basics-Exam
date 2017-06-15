using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldPeopleNum = int.Parse(Console.ReadLine());
            int studentsNum = int.Parse(Console.ReadLine());
            int nightsNum = int.Parse(Console.ReadLine());
            string tipeTransport = Console.ReadLine().ToLower();

            double priceTransportOldPeople=00.0;
            double priceTransportStudent=00.0;
            if (tipeTransport == "train")
            {
                if ((oldPeopleNum + studentsNum) >= 50)
                {
                    priceTransportOldPeople = oldPeopleNum * 24.99 * 2;
                    priceTransportOldPeople -= priceTransportOldPeople * 0.50;
                    priceTransportStudent = studentsNum * 14.99 * 2;
                    priceTransportStudent -= priceTransportStudent * 0.50;
                }
                else
                {
                    priceTransportOldPeople = oldPeopleNum * 24.99 * 2;
                    priceTransportStudent = studentsNum * 14.99 * 2;
                }
            }
            else if (tipeTransport == "bus")
            {
                priceTransportOldPeople = oldPeopleNum * 32.50 * 2;
                priceTransportStudent = studentsNum * 28.50 * 2;
            }
            else if (tipeTransport == "boat")
            {
                priceTransportOldPeople = oldPeopleNum * 42.99 * 2;
                priceTransportStudent = studentsNum * 39.99 * 2;
            }
            else if (tipeTransport == "airplane")
            {
                priceTransportOldPeople = oldPeopleNum * 70.00 * 2;
                priceTransportStudent = studentsNum * 50.00 * 2;
            }

            var hotelPrice = nightsNum * 82.99;
            var comission = (priceTransportOldPeople + priceTransportStudent + hotelPrice) * 0.10;

            var totalPrice = priceTransportOldPeople + priceTransportStudent + hotelPrice + comission;

            Console.WriteLine("{0:f2}", totalPrice);

        }
    }
}
