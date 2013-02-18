/* Write a program that removes from a text file all words listed in given another text file. 
 Handle all possible exceptions in your methods. */

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteAllWordsStartingWithTest
{
    static void Main()
    {
        string wordPattern, text, textReplaced;
        try
        {
            StreamReader readText = new StreamReader("../../text.txt");
            StreamReader readWords = new StreamReader("../../text-words.txt");
            StreamWriter writeText = new StreamWriter("../../text-temp.txt");
            using (readText)
            using (readWords)
            using (writeText)
            {
                wordPattern = @"\b(" + String.Join("|", File.ReadAllLines("../../text-words.txt")) + @")\b";
                while (readText.EndOfStream == false)
                {
                    text = readText.ReadLine();
                    textReplaced = Regex.Replace(text, wordPattern, "");
                    writeText.WriteLine(textReplaced);
                }
            }
            File.Delete("../../text.txt");
            File.Move("../../text-temp.txt", "../../text.txt");
        }
        catch (Exception exception)
        {
            Console.WriteLine("{0}: \n{1}\n", exception.GetType(), exception.Message);
        }
    }
}