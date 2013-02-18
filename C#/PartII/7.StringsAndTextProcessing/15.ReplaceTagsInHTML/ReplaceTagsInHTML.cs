/* Write a program that replaces in a HTML document given as string all the tags 
 <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment: */

using System;
using System.Text.RegularExpressions;

class ReplaceTagsInHTML
{
    static void Main()
    {
        string input = @"<p>Please visit <a href=""http://academy.telerik.com"">
our site</a> to choose a training course. 
Also visit <a href=""www.devbg.org"">our forum</a> 
to discuss the courses.</p>";
        string patternStart = "<a href=\"";
        string patternMid = "\">";
        string patternEnd = "</a>";
        Match start = Regex.Match(input, patternStart);
        input = Regex.Replace(input, patternStart, "[URL=");
        Match mid = Regex.Match(input, patternMid);
        input = Regex.Replace(input, patternMid, "]");
        Match end = Regex.Match(input, patternEnd);
        input = Regex.Replace(input, patternEnd, "[/URL]");
        Console.WriteLine(input);
    }
}