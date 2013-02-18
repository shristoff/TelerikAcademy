/* Write a program that reads a list of words from a file words.txt and finds how many times each of the
 words is contained in another file test.txt. The result should be written in the file result.txt and the 
 words should be sorted by the number of their occurrences in descending order. 
 Handle all possible exceptions in your methods. */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class CountWordsFromFileWriteSorted
{
    static void Main()
    {
        List<string> words = new List<string>();
        string[] wordsArray;
        int i = 0;
        string readLine = "";
        try
        {
            StreamReader readTest = new StreamReader("../../test.txt");
            StreamReader readWords = new StreamReader("../../words.txt");
            StreamWriter writeResult = new StreamWriter("../../result.txt");
            using (readTest)
            using (readWords)
            using (writeResult)
            {
                while (!readWords.EndOfStream)
                {
                    words.Add(readWords.ReadLine());
                }
                int[] wordCounter = new int[words.Count];
                while (readLine != null)
                {
                    for (i = 0; i < words.Count; i++)
                    {
                        Match match = Regex.Match(readLine, (@"\b" + words[i] + @"\b"));
                        if (match.Success)
                            wordCounter[i]++;
                    }
                    readLine = readTest.ReadLine();
                }
                wordsArray = words.ToArray();
                Array.Sort(wordCounter, wordsArray);
                for (i = words.Count - 1; i >= 0; i--)
                {
                    writeResult.WriteLine("{0} - {1} times", wordsArray[i], wordCounter[i]);
                }
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine("{0}: \n{1}\n", exception.GetType(), exception.Message);
        }
    }
}