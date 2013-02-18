using System;
using System.Numerics;

class PrintFirst100FibonachiNumbers
{
    static void Main()
    {
        byte i = 0;
        BigInteger n0 = 0;
        BigInteger n1 = 1;
        BigInteger n2;
        for (i = 1; i<=100; i++)
        {
            Console.WriteLine("{0,-10}{1,20}", i, n0);
            n2 = n1 + n0;
            n0 = n1;
            n1 = n2;
        }
    }
}