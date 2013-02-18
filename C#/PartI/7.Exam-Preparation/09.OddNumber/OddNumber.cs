/*You are given a list of N integer numbers all but one of which appears an even number of times.
Write a program to find the one integer which appears an odd number of times.*/

using System;

class OddNumber
{
    static void Main()
    {
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        long[] numbers = new long[N];
        long OddNumber;
        int i = 0;
        for (i = 0; i < numbers.Length; i++)
        {
            string NumStr = Console.ReadLine();
            numbers[i] = long.Parse(NumStr);
        }
        OddNumber = numbers[0];
        for (i = 1; i < numbers.Length; i++)
        {
             OddNumber = OddNumber ^ numbers[i];
        }
        Console.WriteLine(OddNumber);
    }
}