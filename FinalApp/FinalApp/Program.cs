using System;


public static class DaysCalc
{
    static void Main(string[] calc)
    {
        Console.WriteLine("What is your birth date? (yyyy/mm/dd)");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
        {
            Console.WriteLine("Invalid date");
            return;
        }


        int daysOld = (DateTime.Today - birthday).Days;
        Console.WriteLine($"You are {daysOld} days old.");
    }
}
