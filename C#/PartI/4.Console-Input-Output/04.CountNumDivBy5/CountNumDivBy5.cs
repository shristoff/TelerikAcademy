using System;

class CountNumDivBy5
{
    static void Main()
    {
        Console.Write("Please enter the beginning of the interval b = ");
        uint b = uint.Parse(Console.ReadLine());
        Console.Write("Please enter the end of the interval e = ");
        uint e = uint.Parse(Console.ReadLine());
        uint p = 0;
        uint reminder = b % 5;
        for (uint i = (b + 5 - reminder); i <= e; i = i + 5)
        {
            if (i % 5 == 0)
            {
                p = p + 1;
            }
        }
        if (reminder == 0)
            p = p + 1;
        Console.WriteLine("p({1},{2}) = {0}", p, b, e);
    }
}