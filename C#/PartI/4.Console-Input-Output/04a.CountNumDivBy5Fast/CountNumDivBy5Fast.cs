using System;

class CountNumDivBy5
{
    static void Main()
    {
        Console.Write("Please enter the beginning of the interval b = ");
        uint b = uint.Parse(Console.ReadLine());
        Console.Write("Please enter the end of the interval e = ");
        uint e = uint.Parse(Console.ReadLine());
        uint bdiv5 = b / 5;
        uint ediv5 = e / 5;
        if (b % 5 == 0)
        {
            bdiv5 = bdiv5 - 1;
        }
        uint p = ediv5 - bdiv5;
        Console.WriteLine("p({1},{2}) = {0}", p, b, e);
    }
}