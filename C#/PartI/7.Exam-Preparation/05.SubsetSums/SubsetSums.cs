/*You are given a list of N numbers. Write a program that counts all non-empty 
 subsets from this list, which have sum of their elements exactly S.*/

using System;

class SubsetSums
{
    static void Main()
    {
        string Sstr = Console.ReadLine();
        long S = long.Parse(Sstr);
        string Nstr = Console.ReadLine();
        byte N = byte.Parse(Nstr);
        long[] numbers = new long[N];
        long sum = 0;
        int SsumSubsets = 0;
        int combinations = 1;
        byte i = 0;
        while (i < N)
        {
            string Numstr = Console.ReadLine();
            long Num = long.Parse(Numstr);
            numbers[i] = Num;
            i++;
        }
        for (i = 1; i <= numbers.Length; i++)
        {
            combinations = 2 * combinations;
        }
        for (int comb = 1; comb < combinations; comb++)
        {
            for (byte j = 0; j < numbers.Length; j++)
            {
                sum = sum + ((comb >> j) & 1) * numbers[j];
            }
            if (sum == S)
            {
                SsumSubsets++;
            }
            sum = 0;
        }
        Console.WriteLine(SsumSubsets);
    }
}