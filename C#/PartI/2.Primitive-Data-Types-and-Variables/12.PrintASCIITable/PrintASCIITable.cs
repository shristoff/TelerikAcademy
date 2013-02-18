using System;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.ASCII;
        Console.WriteLine("    " + "ASCII code" + "\t\t      symbol");
        for (char c = (char)0; c <= (char)255; ++c)
        {
            Console.Write("\t" + (int)c + "\t\t\t");
            Console.WriteLine(c);
        }
    }
}