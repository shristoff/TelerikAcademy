/* Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. */

using System;

class StrToUnicodeCharLiteral
{
    static void Main()
    {
        string str = "sdfsadf";
        string[] strToHex = new string[str.Length];
        int i = 0;
        foreach (char letter in str)
        {
            strToHex[i] = String.Format("\\u{0:X4}", (int)letter);
            Console.Write(strToHex[i]);
            i++;
        }
        Console.WriteLine();
    }
}