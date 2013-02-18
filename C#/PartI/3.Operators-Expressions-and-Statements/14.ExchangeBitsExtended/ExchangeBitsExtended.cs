using System;

class ExchangeBitsExtended
{
    static void Main()
    {
        Console.Write("please enter a positive integer number n = ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("the binary format of n is: {0}", Convert.ToString(n, 2));
        Console.Write("please enter the beginning of the first interval you want to exchange p = ");
        byte p = byte.Parse(Console.ReadLine());
        Console.Write("please enter the beginning of the second interval you want to exchange q = ");
        byte q = byte.Parse(Console.ReadLine());
        Console.Write("please enter the length of the interval you want to exchange k = ");
        byte k = byte.Parse(Console.ReadLine());
        for (byte i = 0; i <= (k - 1); i++)
        {
            uint maskp = 1;
            maskp = maskp << (p + i);
            uint nandmaskp = n & maskp;
            uint bitp = nandmaskp >> (p + i);
            uint maskq = 1;
            maskq = maskq << (q + i);
            uint nandmaskq = n & maskq;
            uint bitq = nandmaskq >> (q + i);
            if (bitp == bitq)
            {
                continue;
            }
            uint n1 = (uint)(bitp == 0 ? (~(1 << (q + i)) & n) : (((uint)1 << (q + i)) | n));
            uint n2 = (uint)(bitq == 0 ? (~(1 << (p + i)) & n1) : (((uint)1 << (p + i)) | n1));
            n = n2;
        }
        string nstr = Convert.ToString(n, 2);
        Console.WriteLine("The new number is {0} which represents as {1} as binary", n, nstr);
    }
}