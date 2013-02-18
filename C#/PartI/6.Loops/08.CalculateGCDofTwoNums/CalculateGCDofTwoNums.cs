/*Write a program that calculates the greatest common divisor (GCD) of given two numbers.
Use the Euclidean algorithm (find it in Internet).*/

using System;

class CalculateGCDofTwoNums
{
    static void Main()
    {
        Console.Write("Please enter positive integer N = ");
        string Nstr = Console.ReadLine();
        decimal N = decimal.Parse(Nstr);
        Console.Write("Please enter positive integer K < N: K = ");
        string Kstr = Console.ReadLine();
        decimal K = decimal.Parse(Kstr);
        do
        {
            N = Math.Abs(N - K);
            if (N != K)
            {
                K = Math.Abs(K - N);
            }
        }
        while (K != N);
        Console.WriteLine("GCD = {0}", N);
    }
}
