/* Write a program that deletes from given text file all odd lines. 
 The result should be in the same file. */

using System;
using System.IO;

class ChangeAFileByDeletingOddLines
{
    static void Main()
    {
        StreamReader readText = new StreamReader("../../Names.txt");
        StreamWriter writeText = new StreamWriter("../../Names-temp.txt");
        using (readText)
        using (writeText)
        {
            int lineNumber = 0;
            string line = readText.ReadLine();
            while (readText.EndOfStream == false)
            {
                lineNumber++;
                if ((lineNumber & 1) == 0)
                {
                    writeText.WriteLine(line);
                }
                line = readText.ReadLine();
            }
        }
        File.Delete("../../Names.txt");
        File.Move("../../Names-temp.txt", "../../Names.txt");
    }
}