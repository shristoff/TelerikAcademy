/* Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe". */

using System;
using System.Text.RegularExpressions;

class ExtractAllPalindromes
{
    static void Main()
    {
        string text = "ABBA is a top level music band. Anna and Hannah are ABBA fans. They all drive Honda Civic";
        string[] words = text.Split(' ', '.', '!', '?');
        bool palindrome = false;
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].ToLower();
            char[] word = words[i].ToCharArray();
            char[] reversedWord = words[i].ToCharArray();
            Array.Reverse(reversedWord);
            for (int c = 0; c < word.Length; c++)
			{
			    palindrome = word[c] == reversedWord[c];
                if (!palindrome)
                    break;
			}
            if (palindrome && words[i].Length > 1)
                Console.WriteLine(words[i]);
        }
    }
}