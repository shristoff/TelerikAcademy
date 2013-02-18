/*You are given a sequence of N positive integer numbers and one binary digit B (0 or 1). 
Your task is to write a program that finds the number of binary digits (B) in each of the N numbers in binary numeral system. */

using System;

class BinaryDigitsCount
{
    static void Main()
    {
        string Bstr = Console.ReadLine();
        byte B = byte.Parse(Bstr);
        string Nstr = Console.ReadLine();
        ushort N = ushort.Parse(Nstr);
        byte[,] ZeroOneCount = new byte[N + 1, 2];
        ushort i = 1;
        uint remainder;
        while (i <= N)
        {
            string Numstr = Console.ReadLine();
            uint Num = uint.Parse(Numstr);
            do
            {
                remainder = Num % 2;
                Num = Num / 2;
                if (remainder == 0)
                    ZeroOneCount[i, 0]++;
                else 
                    ZeroOneCount[i, 1]++;
            }
            while (Num > 0);
            i++;
        }
        for (i = 1; i <= N; i++)
        {
            if (B == 0)
                Console.WriteLine(ZeroOneCount[i, 0]);
            else
                Console.WriteLine(ZeroOneCount[i, 1]);
        }

    }
}