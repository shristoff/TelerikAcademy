/* Write a program that deletes from a text file all words that start with 
 the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _. */

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteAllWordsStartingWithTest
{
    static void Main()
    {
        StreamReader readText = new StreamReader("../../text.txt");
        StreamWriter writeText = new StreamWriter("../../text-output.txt");
        using (readText)
        using (writeText)
        {
            while (readText.EndOfStream == false)
            {
                writeText.WriteLine(Regex.Replace(readText.ReadLine(), @"\btest\w*\b", ""));
            }
        }
        File.Delete("../../text.txt");
        File.Move("../../text-output.txt", "../../text.txt");
    }
}