/* A dictionary is stored as a sequence of text lines containing words and their explanations. 
 Write a program that enters a word and translates it by using the dictionary. */

using System;
using System.Text.RegularExpressions;

class TranslateWordWithDict
{
    static void Main()
    {
        string dictionary = 
@".NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes
method – a code block containing a series of statements.";
        Match word = Regex.Match(dictionary, @"^[^\s]+", RegexOptions.Multiline);  //regex for the word with Multiline option
        Match definition = Regex.Match(dictionary, @"[–\s].\b[\w]*.+", RegexOptions.Multiline); //regex for the definition with Multiline option
        Console.Write("Please enter term (.NET, CLR, namespace or method): "); 
        string wordToExplain = Console.ReadLine();  //reading of the word to know which definition we should provide
        while (word.Success)
        {
            if (wordToExplain == word.Value)    //if we recognize the wntered word 
            {
                Console.WriteLine("{0} {1}", word.Value, definition.Value);  //user-friendly print of the word and the definition
                break;                                                      //finish the program
            }
            word = word.NextMatch();                    //if no word is recognized go to the next word to check for it
            definition = definition.NextMatch();        //move to the next definition also
        }
        Console.WriteLine();
    }
}