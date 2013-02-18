using System;

class ReadNPrintAllFrom1ToN
{
    static void Main()
    {
        Console.Write("Please enter positive integer number n = ");
        string nstr = Console.ReadLine();
        int n = int.Parse(nstr);
        int i = 1;
        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
