/* Write a program that extracts from given XML file all the text without the tags. */

using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractTextWithoutTagsFromXML
{
    static void Main()
    {
        StreamReader readXML = new StreamReader("../../XML.txt");
        StreamWriter writeText = new StreamWriter("../../textOnly.txt");
        string pattern = @">(.*?)<";
        using (readXML)
        using (writeText)
        {
            Match match = Regex.Match(readXML.ReadToEnd(), pattern);
            while (match.Success)
            {
                if (!(String.IsNullOrWhiteSpace(match.Groups[1].Value)))
                    writeText.WriteLine(match.Groups[1].Value);
                match = match.NextMatch();
            }
        }
    }
}