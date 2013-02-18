/* Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!". */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ReverseWordsInSentence
{
    static void Main()
    {
        string straightSentence = "Силата е търпение, време и желание!";
        char sign = straightSentence[straightSentence.Length - 1];   //save the sentence final symbol in sign
        Match word = Regex.Match(straightSentence, @"\b[^\s,.?!;]+|[,;]", RegexOptions.RightToLeft);
        List<string> words = new List<string>();  //extract the words from the sentence backwards incl. the symbols , and ;
        while (word.Success)                        //initialize List for adding the words
        {                                           //while the match is successfull (while there are still words)
            if (word.Value != "," && word.Value != ";")  //if we have word, not comma or ;
                words.Add(" " + word.Value);        //saving the words in the List with space in the beginning
            else
                words.Add(word.Value);   //if we have matched , or ; we don't add space
            word = word.NextMatch();     //moving to the next word
        }
        char[] firstWord = words[0].ToCharArray();
        firstWord[1] = char.ToUpper(firstWord[1]);
        words[0] = new string(firstWord);                             //making the new first letter uppercase
        words[0] = words[0].Substring(1);                          //removing the first space from the first word

        char[] lastWord = words[words.Count - 1].ToCharArray();    
        lastWord[1] = char.ToLower(lastWord[1]);
        words[words.Count - 1] = new string(lastWord);               //making the ex-first letter lowercase

        words[words.Count - 1] = words[words.Count - 1] + sign;     //adding the previous final symbol to the end
        string reversedSentence = string.Join<string>("", words); //creating a new string with the reversedSentence
        Console.WriteLine(reversedSentence);
    }
}