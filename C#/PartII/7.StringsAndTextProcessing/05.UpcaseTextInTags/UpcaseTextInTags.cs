/* You are given a text. Write a program that changes the text in all regions surrounded by the 
tags <upcase> and </upcase> to uppercase. The tags cannot be nested */

using System;
using System.Text.RegularExpressions;

class UpcaseTextInTags
{
    static void Main()
    {
        string text = @"Objects <upcase> can </upcase> be <upcase> converted to strings </upcase> and could be formatted in <upcase> different styles </upcase> using ToString() method";
        string patternUpper = "<upcase>(.*?)</upcase>";
        //string patternLower = "</upcase>.*?<upcase>";
        Match match1 = Regex.Match(text, patternUpper, RegexOptions.IgnoreCase);
        while (match1.Success)
        { 
            string toUpper = match1.Groups[1].Value.ToUpper();
            text = Regex.Replace(text, match1.Groups[1].Value, toUpper);
            match1 = match1.NextMatch();
        }
        //Match match2 = Regex.Match(text, patternLower, RegexOptions.IgnoreCase);
        //string toLower = match2.Value.ToLower();
        //text = Regex.Replace(text, patternLower, toLower);
        Console.WriteLine(text);
    }
}