/* Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints 
 the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian. */

using System;
using System.Globalization;

class PrintDateTimeAfter6h30m
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.Write("Please enter date and time in format day.month.year hour:minute:second: ");
        DateTime firstDate = DateTime.Parse(string.Format("{0:dd.MM.yyyy HH:mm:ss}", Console.ReadLine()));
        DateTime after6h30min = firstDate.AddMinutes(390);
        Console.WriteLine(after6h30min);
    }
}