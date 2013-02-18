/* Write a program that compares two text files line by line and prints the number 
 of lines that are the same and the number of lines that are different. 
 Assume the files have equal number of lines. */

using System;
using System.IO;

class CompareLinesOf2FilesPrintNumbers
{
    static void Main()
    {
        int equalLinesNum = 0;
        int diffLinesNum = 0;
        StreamReader readText = new StreamReader("../../text.txt");
        StreamReader readText1Text2 = new StreamReader("../../text&text1.txt");
        using (readText)
        using (readText1Text2)
        {
            while (readText.EndOfStream == false || readText1Text2.EndOfStream == false)
            {
                string first = readText.ReadLine();
                string second = readText1Text2.ReadLine();
                if (first == second)
                    equalLinesNum++;
                else
                    diffLinesNum++;
            }
        }
        Console.WriteLine("The equal lines are {0}.\nThe different lines are {1}.\n", equalLinesNum, diffLinesNum);
    }
}