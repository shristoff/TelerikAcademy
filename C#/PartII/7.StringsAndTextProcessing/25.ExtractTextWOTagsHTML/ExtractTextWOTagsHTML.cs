/* Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. */

using System;
using System.Text.RegularExpressions;

class ExtractTextWOTagsHTML
{
    static void Main()
    {
        string html = @"<html> <head> <title>News</title> </head> <body> <p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p> </body> </html>";
        string pattern = @">(.*?)<";
        Match match = Regex.Match(html, pattern);
        while (match.Success)
        {
            if (!(String.IsNullOrWhiteSpace(match.Groups[1].Value)))
                Console.Write("{0} ", match.Groups[1].Value);
            match = match.NextMatch();
        }
        Console.WriteLine();
    }
}