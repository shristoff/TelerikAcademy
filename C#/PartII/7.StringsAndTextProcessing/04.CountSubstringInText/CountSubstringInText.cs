/* Write a program that finds how many times a substring is contained in a given text (perform case insensitive search). */
 
using System;
using System.Text.RegularExpressions;

class CountSubstringInText
{
    static void Main()
    {
        string text = @"Символи, литерали и метасимволи. 
                        Escaping последователности, метасимволи за класове, 
                        метасимволи за количество, метасимволи за местоположение";
        string pattern = "симв";
        int counter = 0;
        Match match = Regex.Match(text, pattern, RegexOptions.IgnoreCase);
        while (match.Success)
        {
            counter++;
            match = match.NextMatch();
        }
        Console.WriteLine("The number of string {0} is {1}", pattern, counter);
    }
}