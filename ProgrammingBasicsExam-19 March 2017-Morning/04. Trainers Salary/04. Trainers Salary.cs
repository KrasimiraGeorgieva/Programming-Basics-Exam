using System;

class Program
{
    static void Main()
    {
        int lecturesNum = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());

        int lecturesJelev = 0;
        int lecturesRoYal = 0;
        int lecturesRoli = 0;
        int lecturesTrofon = 0;
        int lecturesSino = 0;
        int lecturesGuest = 0;

        for (int i = 0; i < lecturesNum; i++)
        {
            string name = Console.ReadLine();
            if (name == "Jelev") { lecturesJelev++; }
            else if (name == "RoYaL") { lecturesRoYal++; }
            else if (name == "Roli") { lecturesRoli++; }
            else if (name == "Trofon") { lecturesTrofon++; }
            else if (name == "Sino") { lecturesSino++; }
            else { lecturesGuest++; }
        }
        var payLecture = budget / lecturesNum;

        Console.WriteLine("Jelev salary: {0:F2} lv",lecturesJelev*payLecture);
        Console.WriteLine("RoYaL salary: {0:F2} lv", lecturesRoYal * payLecture);
        Console.WriteLine("Roli salary: {0:F2} lv", lecturesRoli * payLecture);
        Console.WriteLine("Trofon salary: {0:F2} lv", lecturesTrofon * payLecture);
        Console.WriteLine("Sino salary: {0:F2} lv", lecturesSino * payLecture);
        Console.WriteLine("Others salary: {0:F2} lv", lecturesGuest * payLecture);
    }
}
