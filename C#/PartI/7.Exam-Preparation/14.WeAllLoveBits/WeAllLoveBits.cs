/* The algorithm takes one positive integer P, makes magic with it and returns a new positive integer. 
He also defined a new number P̃ which represents the number P in binary numeral system with inverted bits. 
All zeros in P are ones in P̃ and all ones in P are zeros in P̃. For example if we have P = 9 (which is 1001 in binary numeral system)
its inverted number P̃ will be equal to 6 (which is 110 in binary numeral system). But that’s not all! He invented another number P̈,
which represents reversed number P in binary numeral system. For example if we have P = 11 (which is 1011 in binary numeral system) 
its reversed number P̈ is equal to 13 (which is 1101 in binary numeral system). Mitko's magical algorithm takes a number P 
and transforms it to a new number Pnew using the following bitwise transformation: Pnew = (P ^ P̃) & P̈.
Your task is to write a program that transforms a sequence of N positive integer numbers using Mitko's algorithm. */

using System;

class WeAllLoveBits
{
    static void Main()
    {
        string Nstr = Console.ReadLine();
        ushort N = ushort.Parse(Nstr);
        int[,] Nums = new int[N, 35];
        short row = 0;
        int col = 0;
        while (row < N)
        {
            string Numstr = Console.ReadLine();
            Nums[row, 32] = int.Parse(Numstr);
            row++;
        }
        for (row = 0; row < N; row++)
        {
            col = 31;
            while (col >= 0)
            {
                Nums[row, col] = (Nums[row, 32] >> col) & 1;
                if (Nums[row, col] == 1)
                    break;
                col--;
            }
            Nums[row, 33] = col;
            col = 0;
            while (col <= 31)
            {
                Nums[row, col] = (Nums[row, 32] >> col) & 1;
                if (Nums[row, col] == 1)
                    break;
                col++;
            }
            Nums[row, 34] = col;
        }
        for (row = 0; row < N; row++)
        {
            for (col = 0; col < 31; col++)
            {
                Nums[row, col] = (Nums[row, 32] >> col) & 1;
            }
        }
        for (row = 0; row < N; row++)
        {
            Nums[row, 32] = 0;
            int i = 0;
            for (col = Math.Max(Nums[row, 33], Nums[row, 34]); col >= Math.Min(Nums[row, 33], Nums[row, 34]); col--)
            {
                Nums[row, 32] = Nums[row, 32] + Nums[row, col] * (int)Math.Pow(2, i);
                i++;
            }
            Console.WriteLine(Nums[row, 32]);
        }
    }
}