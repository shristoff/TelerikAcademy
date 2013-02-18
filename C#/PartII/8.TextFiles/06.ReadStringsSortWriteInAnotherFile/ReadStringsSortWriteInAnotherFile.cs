/* Write a program that reads a text file containing a list of strings, 
sorts them and saves them to another text file. Example:
	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter */

using System;
using System.IO;

class ReadStringsSortWriteInAnotherFile
{
    static void Main()
    {
        StreamReader readText = new StreamReader("../../Names.txt");
        StreamWriter writeText = new StreamWriter("../../Sorted.txt");
        string[] names;
        using (readText)
        using (writeText)
        {
            names = readText.ReadToEnd().Split('\n');
            Array.Sort(names);
            foreach (string name in names)
            {
                writeText.WriteLine(name);
            }
        }
    }
}