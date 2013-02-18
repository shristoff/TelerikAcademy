/* Write a program that reads a text file and prints on the console its odd lines. */

using System;
using System.IO;

class PrintOddLinesFromTextFile
{
    static void Main()
    {
        Console.SetWindowSize(130, 40);
        StreamReader readText = new StreamReader("../../text.txt");
        using (readText)
        {
            int lineNumber = 0;
            string line = readText.ReadLine();
            while (readText.EndOfStream == false)
            {
                lineNumber++;
                if ((lineNumber & 1) == 1)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }
                line = readText.ReadLine();
            }
        }
    }
}
