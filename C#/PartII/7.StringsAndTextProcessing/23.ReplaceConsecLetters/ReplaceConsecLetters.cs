/* Write a program that reads a string from the console and replaces all series of consecutive identical 
letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa". */

using System;
using System.Collections.Generic;

class ReplaceConsecLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssa";
        List<char> textToChar = new List<char>();
        textToChar.Add(text[0]);
        for (int i = 1; i + 1< text.Length; i++)
        {
            if (text[i] != text[i + 1])
                textToChar.Add(text[i + 1]);
        }
        string newText = new string(textToChar.ToArray());
        Console.WriteLine(newText);
    }
}