using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Please enter an integer number i = ");   //101101 i=89
        int i = int.Parse(Console.ReadLine());                  //543210 bit positions
        Console.Write("Please enter bit position b = ");        //b = 4
        int b = int.Parse(Console.ReadLine());  
        int mask = 1 << b;                                      //010000
        int iAndmask = i & mask;                                //000000
        int bit = iAndmask >> b;                                //000000
        Console.WriteLine("The bit at position {0} is {1}", b, bit); //0
    }
}