/* Write a program that concatenates two text files into another text file. */

using System;
using System.IO;

class Concatenate2TextFilesIn1
{
    static void Main()
    {
        string text, text1;
        StreamReader readText = new StreamReader("../../text.txt");
        StreamReader readText1 = new StreamReader("../../text1.txt");
        StreamWriter writeResult = new StreamWriter("../../text&text1.txt");
        using (readText)
        using (readText1)
        using (writeResult)
        {
            text = readText.ReadToEnd();
            text1 = readText1.ReadToEnd();
            writeResult.WriteLine(text);
            writeResult.WriteLine(text1);
        }
    }
}