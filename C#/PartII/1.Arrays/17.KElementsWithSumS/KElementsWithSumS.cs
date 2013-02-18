/* * Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
Find in the array a subset of K elements that have sum S or indicate about its absence.*/

using System;
using System.Collections.Generic;

class SubsetSums
{
    static void Main()
    {
        Console.WriteLine("Enter sum S: ");
        string Sstr = Console.ReadLine();
        int S = int.Parse(Sstr);
        Console.WriteLine("Enter number of subset elements K: ");
        string Kstr = Console.ReadLine();
        int K = int.Parse(Kstr);
        Console.WriteLine("Enter number of elements in the array N: ");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        int[] numbers = new int[N];
        List<int> subset = new List<int>();
        int sum = 0, SsumSubsets = 0, combinations = 1;
        byte i = 0, j = 0;
        Console.WriteLine("Enter array numbers: ");
        while (i < N)
        {
            string Numstr = Console.ReadLine();
            int Num = int.Parse(Numstr);
            numbers[i] = Num;
            i++;
        }
        for (i = 1; i <= numbers.Length; i++)
        {
            combinations = 2 * combinations;
        }
        for (int comb = 1; comb < combinations; comb++)
        {
            for (j = 0; j < numbers.Length; j++)
            {
                sum = sum + ((comb >> j) & 1) * numbers[j];
                if (((comb >> j) & 1) != 0)
                    subset.Add(numbers[j]);
            }
            if (sum == S && subset.Count == K)
            {
                j = 0;
                SsumSubsets++;
                Console.Write("\nSubset number {0} members are: ", SsumSubsets);
                foreach (int item in subset)
                {
                    Console.Write("{0} ", subset[j]);
                    j++;
                }
            }
            sum = 0;
            subset.RemoveRange(0, subset.Count);
        }
        Console.WriteLine("\nTotal number of subsets with K members with sum S is: {0}", SsumSubsets);
    }
}
