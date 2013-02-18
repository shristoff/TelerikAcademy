using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("please enter a positive integer number n = ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("the binary format of n is: {0}", Convert.ToString(n, 2));
        for (byte i = 0; i <= 2; i++)
        {
            uint mask3 = 1;
            mask3 = mask3 << (3 + i);
            uint nandmask3 = n & mask3;
            uint bit3 = nandmask3 >> (3 + i);
            uint mask24 = 1;
            mask24 = mask24 << (24 + i);
            uint nandmask24 = n & mask24;
            uint bit24 = nandmask24 >> (24 + i);
            if (bit3 == bit24)
            {
                continue;
            }
            uint n1 = (uint)(bit3 == 0 ? (~(1 << (24 + i)) & n) : (((uint)1 << (24 + i)) | n));
            uint n2 = (uint)(bit24 == 0 ? (~(1 << (3 + i)) & n1) : (((uint)1 << (3 + i)) | n1));
            n = n2;
        }
        string nstr = Convert.ToString(n, 2);
        Console.WriteLine("The new number is {0} which represents as {1} as binary", n, nstr);
    }
}