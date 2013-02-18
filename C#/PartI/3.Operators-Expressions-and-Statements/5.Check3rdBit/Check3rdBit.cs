using System;

class Check3rdBit
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer number: ");
        int num = int.Parse(Console.ReadLine());  // 101000100; 11001
        int mask = 1 << 4;                        // 000001000; 01000
        int numAndmask = num & mask;              // 000000000; 01000
        int bit = numAndmask >> 4;                // 000000000; 00001
        Console.WriteLine("The third bit is: {0}", bit);
    }
}