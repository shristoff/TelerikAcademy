using System;

class CheckIfBitpIs1
{
    static void Main()
    {
        Console.Write("Please enter an integer number v = ");
        int v = int.Parse(Console.ReadLine());      //10110 v = 22
        Console.Write("Please enter bit position p = ");  //43210 bit positions
        int p = int.Parse(Console.ReadLine());      //p = 2
        int mask = 1 << p;                          //00100
        int vAndmask = v & mask;                    //00100
        int bit = vAndmask >> p;                    //00001
        bool bitPis1 = bit == 1;                    //True
        Console.WriteLine("\"The bit at position {0} is 1\" is: {1}", p, bitPis1);
    }
}
