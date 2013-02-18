/* Modify the solution of the previous problem to replace only whole words (not substrings). */

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWordsIn100MBFile
{
    static void Main()
    {
        StreamReader readText = new StreamReader("../../text100MB.txt");
        StreamWriter writeText = new StreamWriter("../../text100MB-output.txt");
        using (readText)
        using (writeText)
        {
            while (readText.EndOfStream == false)
            {
                writeText.WriteLine(Regex.Replace(readText.ReadLine(), @"\bstart\b", "finish"));
            }
        }
    }
}