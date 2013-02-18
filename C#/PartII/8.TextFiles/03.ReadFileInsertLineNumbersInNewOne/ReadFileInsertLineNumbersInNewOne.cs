/* Write a program that reads a text file and inserts line numbers in front of each of its lines. 
 The result should be written to another text file. */

using System;
using System.IO;

class ReadFileInsertLineNumbersInNewOne
{
    static void Main()
    {
        int lineNumber = 0;
        StreamReader readText = new StreamReader("../../text.txt");
        StreamWriter writeText = new StreamWriter("../../textWithLineNumbers.txt");
        using (readText)
        {
            string line = readText.ReadLine();
            using (writeText)
            {
                while (line != null)
                {
                    lineNumber++;
                    writeText.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = readText.ReadLine();
                }
            }
        }
    }
}