/* Write a program that replaces all occurrences of the substring "start" with 
 the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).*/

using System;
using System.IO;

class ReplaceStartWithFinishIn100MBFile
{
    static void Main()
    {
        StreamReader readText = new StreamReader("../../text100MB.txt");
        StreamWriter writeText = new StreamWriter("../../text100MB-output.txt");
        using (readText)
        {
            while (readText.EndOfStream == false)
            {
                writeText.WriteLine(readText.ReadLine().Replace("start", "finish"));
            }
        }
    }
}