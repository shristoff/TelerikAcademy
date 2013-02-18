/*Write a program that reads a number N and calculates the sum of the first N members of 
the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.*/

using System;
using System.Numerics;

class PrintNFibonachiNumbers
{
    static void Main()
    {
        Console.Write("Please enter positive integer N = ");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        byte i = 0;
        BigInteger n0 = 0;
        BigInteger n1 = 1;
        BigInteger n2;
        BigInteger S = 0;
        for (i = 1; i <= N; i++)
        {
            Console.WriteLine("{0,-10}{1,25}{2,30}", i, n0, S);
            n2 = n1 + n0;
            n0 = n1;
            n1 = n2;
            S += n0;
        }
    }
}
