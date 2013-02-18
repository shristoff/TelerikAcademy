/* Write a program that reads a string from the console and lists all different words in 
 the string along with information how many times each word is found. */

using System;

class PrintCountAllDifWords
{
    static void Main()
    {
        string text = "ABBA is a top level music band and we as music fans love ABBA.";
        text = text.ToLower();
        string[] words = text.Split(' ', '.', '!', '?');
        Array.Sort(words);
        int[] countWords = new int[words.Length];
        int i, c;
        countWords[0] = 1;
        for (i = 1, c = 0; i + 1 < countWords.Length; i++)
        {
            if (words[i] == words[i + 1])
                countWords[c]++;
            else
            {
                c++;
                countWords[c]++;
            }
        }
        c = 0;
        i = countWords[0];
        while (countWords[c] > 0)
        {
            Console.WriteLine("Symbol \"{0}\" - {1} times", words[i], countWords[c]);
            c++;
            i = i + countWords[c];
        }

    }
}
