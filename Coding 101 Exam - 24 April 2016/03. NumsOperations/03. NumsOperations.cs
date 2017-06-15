using System;

class NumsOperations
{
    static void Main()
    {
        //    int n1 = int.Parse(Console.ReadLine());
        //    int n2 = int.Parse(Console.ReadLine());
        //    char a = char.Parse(Console.ReadLine()); // типа данни е char
        //    string b;
        //    if (a == '+' || a == '-' || a == '*') // двойните кавички "" се заменят с единични ''
        //    {
        //        if (a == '+')// двойните кавички "" се заменят с единични ''
        //        {
        //            if ((n1 + n2) % 2 == 0)
        //                b = "even";
        //            else
        //                b = "odd";
        //            Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, a, n2, n1 + n2, b);
        //        }
        //        else if (a == '-')// двойните кавички "" се заменят с единични ''
        //        {
        //            if ((n1 - n2) % 2 == 0)
        //                b = "even";
        //            else
        //                b = "odd";
        //            Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, a, n2, n1 - n2, b);
        //        }
        //        else if (a == '*')// двойните кавички "" се заменят с единични ''
        //        {
        //            if ((n1 * n2) % 2 == 0)
        //                b = "even";
        //            else
        //                b = "odd";
        //            Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, a, n2, n1 * n2, b);
        //        }
        //    }
        //    else if (a == '/')// двойните кавички "" се заменят с единични ''
        //    {
        //        if (n1 == 0)
        //            Console.WriteLine("Cannot divide {0} by zero", n2);
        //        else if (n2 == 0)
        //            Console.WriteLine("Cannot divide {0} by zero", n1);
        //        else
        //            Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, (double)n1 / n2); // по условието при деление резултата е фораматиран до вторият знак след дес.запетая
        //    }
        //    else if (a == '%')// двойните кавички "" се заменят с единични ''
        //    {
        //        if (n1 == 0)
        //            Console.WriteLine("Cannot divide {0} by zero", n2);
        //        else if (n2 == 0)
        //            Console.WriteLine("Cannot divide {0} by zero", n1);
        //        else
        //            Console.WriteLine("{0} % {1} = {2}", n1, n2, n1 % n2);
        //    }
        //}


        //// ЕТО ГО И МОЕТО РЕШЕНИЕ

        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        char sign = char.Parse(Console.ReadLine());

        if (sign == '+')
        {
            if ((num1 + num2) % 2 == 0)
                Console.WriteLine("{0} {1} {2} = {3} - even", num1, sign, num2, (num1 + num2));
            else
                Console.WriteLine("{0} {1} {2} = {3} - odd", num1, sign, num2, (num1 + num2));
        }
        else if (sign == '-')
        {
            if ((num1 - num2) % 2 == 0)
                Console.WriteLine("{0} {1} {2} = {3} - even", num1, sign, num2, (num1 - num2));
            else
                Console.WriteLine("{0} {1} {2} = {3} - odd", num1, sign, num2, (num1 - num2));
        }
        else if (sign == '*')
        {
            if ((num1 * num2) % 2 == 0)
                Console.WriteLine("{0} {1} {2} = {3} - even", num1, sign, num2, (num1 * num2));
            else
                Console.WriteLine("{0} {1} {2} = {3} - odd", num1, sign, num2, (num1 * num2));
        }
        else if (sign == '/')
        {
            if (num2 == 0)
                Console.WriteLine("Cannot divide {0} by zero", num1);
            else
                Console.WriteLine("{0} {1} {2} = {3:f2}", num1, sign, num2, (num1 / num2));
        }
        else if (sign == '%')
        {
            if (num2 == 0)
                Console.WriteLine("Cannot divide {0} by zero", num1);
            else
                Console.WriteLine("{0} {1} {2} = {3}", num1, sign, num2, (num1 % num2));
        }
    }
}
