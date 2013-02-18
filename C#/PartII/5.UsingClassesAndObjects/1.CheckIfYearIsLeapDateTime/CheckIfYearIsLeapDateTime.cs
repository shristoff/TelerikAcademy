/* Write a program that reads a year from the console and checks whether it is a leap. Use DateTime. */

using System;

class CheckIfYearIsLeapDateTime
{
    static void Main()
    {
        Console.WriteLine("Please enter an year:");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("The year is leap is: {0}", DateTime.IsLeapYear(year));
    }
}