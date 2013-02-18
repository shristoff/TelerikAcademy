/* Write a program that reads a string from the console and prints all different letters in the string along 
 with information how many times each letter is found.  */

using System;

class PrintCountAllDifLetters
{
    static void Main()
    {
        string text = "ABBA is a top level music band.";
        text = text.ToLower();
        char[] textToArr = text.ToCharArray();
        int[] countChars = new int[text.Length];
        int i = 0, c;
        Array.Sort(textToArr);
        countChars[0] = 1;
        for (i = 0, c = 0; i + 1 < textToArr.Length; i++)
        {
            if (textToArr[i] == textToArr[i + 1])
                countChars[c]++;
            else
            {
                c++;
                countChars[c]++;
            }
        }
        c = 0;
        i = countChars[0] - 1;
        while (countChars[c] > 0)
        {
            Console.WriteLine("Symbol \"{0}\" - {1} times", textToArr[i], countChars[c]);
            c++;
            i = i + countChars[c];
        }
    }
}