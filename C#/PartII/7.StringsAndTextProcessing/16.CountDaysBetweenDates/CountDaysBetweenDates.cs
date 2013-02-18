/* Write a program that reads two dates in the format: day.month.year and calculates the number of 
 days between them. Example: Enter the first date: 27.02.2006
                             Enter the second date: 3.03.2004
                             Distance: 4 days */

using System;

class CountDaysBetweenDates
{
    static void Main()
    {
        Console.Write("Please enter the first date: ");
        DateTime firstDate = DateTime.Parse(string.Format("{0:dd.MM.YYYY}", Console.ReadLine()));
        Console.Write("Please enter the second date: ");
        DateTime secondDate = DateTime.Parse(string.Format("{0:dd.MM.YYYY}", Console.ReadLine()));
        secondDate = new DateTime(firstDate.Year, secondDate.Month, secondDate.Day);
        if (firstDate >= secondDate)
            Console.WriteLine("Distance: {0:dd} day(s)", firstDate - secondDate);
        else
            Console.WriteLine("Distance: {0:dd} day(s)", secondDate - firstDate);
    }
}