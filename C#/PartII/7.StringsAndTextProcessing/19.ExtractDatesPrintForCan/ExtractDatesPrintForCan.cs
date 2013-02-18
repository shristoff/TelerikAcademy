/* Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
 Display them in the standard date format for Canada. */

using System;
using System.Text.RegularExpressions;

class ExtractDatesPrintForCan
{
    static void Main()
    {
        string textWithDates = "Stefany's birthday is 22.12.1978, mine is 05.05.2000 and Johns's is 03.02.1944";
        string datePattern = @"[0-3]{1}[0-9]{1}\.[0-1]{1}[0-9]{1}\.[\d]{4}";
        Match dateMatch = Regex.Match(textWithDates, datePattern);
        Console.WriteLine("The text is:\n\n{0}\n", textWithDates);
        Console.WriteLine("The dates in the text are:\n");
        while (dateMatch.Success)
        {
            Console.WriteLine(dateMatch.Value);
            dateMatch = dateMatch.NextMatch();
        }
        Console.WriteLine();
    }
}