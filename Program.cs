using System;

class Program
{
    static void Main()
    {
        
        int year = 2024;
        int month = 8;

      
        DateTime firstDay = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);
        int startDay = (int)firstDay.DayOfWeek;

       
        int[,] calendar = new int[6, 7];
        int currentDay = 1;

        
        for (int week = 0; week < 6; week++)
        {
            for (int day = 0; day < 7; day++)
            {
                
                if (week == 0 && day < startDay || currentDay > daysInMonth)
                {
                    calendar[week, day] = 0;
                }
                else
                {
                    calendar[week, day] = currentDay++;
                }
            }
        }

        
        Console.WriteLine($"Calendar for {firstDay:MMMM yyyy}");
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

      
        for (int week = 0; week < 6; week++)
        {
            for (int day = 0; day < 7; day++)
            {
                
                if (calendar[week, day] == 0)
                {
                    Console.Write("   ");
                }
                else
                {
                    Console.Write($"{calendar[week, day],2} ");
                }
            }
            Console.WriteLine(); // Move to the next week
        }
    }
}
