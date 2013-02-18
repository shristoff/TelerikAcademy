/* Write a program that extracts from a given text all sentences containing given word.*/

using System;
using System.Text.RegularExpressions;

class ExtrSentenceIfHaveWord
{
    static void Main()
    {
        string paragraph = @"This is a short sentence. 
This is only a test;
Oh, this is another one! 
Is there longer sentence than this?";
        Console.WriteLine("The paragraph which we search through is: \n\n{0}", paragraph);
        string pattern = @"[A-Z][^.|?|!|;]*sentence[^.|?|!|;]*[.|?|!|;]*";
        Match match = Regex.Match(paragraph, pattern);
        Console.WriteLine("\nThe sentences which contain the word \"sentence\" are:\n");
        while (match.Success)
        {
            Console.WriteLine(match);
            match = match.NextMatch();
        }
        Console.WriteLine();
    }
}