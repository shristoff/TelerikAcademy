/* We are given a string containing a list of forbidden words and a text containing some of these words. 
 Write a program that replaces the forbidden words with asterisks.*/

using System;
using System.Text.RegularExpressions;

class ReplaceForbiddenWords
{
    static void Main()
    {
        string uncensored = @"For a heavy metal band raps a different way
We like to different and not cliche
They say rap and metal can never mix
Well all of them can suck our...""
""DICKS!""
""Suck my motherfucking dick!";
        string forbiddenWords = "(suck)|(dick)|(fuck)";
        Console.WriteLine("Uncensored text:\n\n{0}\n", uncensored);
        string censored = uncensored;
        Match match = Regex.Match(uncensored, forbiddenWords, RegexOptions.IgnoreCase);
        for (int i = 1; i <= 3; i++)
        {
            string starsWord = new string('*', match.Groups[i].Value.Length);
            censored = Regex.Replace(censored, forbiddenWords, starsWord, RegexOptions.IgnoreCase);
        }
        Console.WriteLine("Censored text:\n\n{0}\n\n", censored);
    }
}