/*The Tribonacci sequence is a sequence in which every next element is made by the sum of the previous three elements 
 from the sequence. Write a computer program that finds the Nth element of the Tribonacci sequence, 
 if you are given the first three elements of the sequence and the number N. 
 Mathematically said: with given T1, T2 and T3 – you must find Tn.*/

using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        string strn1 = Console.ReadLine();
        BigInteger n1 = BigInteger.Parse(strn1);
        string strn2 = Console.ReadLine();
        BigInteger n2 = BigInteger.Parse(strn2);
        string strn3 = Console.ReadLine();
        BigInteger n3 = BigInteger.Parse(strn3);
        string strN = Console.ReadLine();
        int N = int.Parse(strN);
        BigInteger sum = 0;
        switch (N)
        {
            case 1:
                sum = n1; break;
            case 2:
                sum = n2; break;
            case 3:
                sum = n3; break;
        }
        for (int i = 4; i <= N; i++)
        {
            sum = n1 + n2 + n3;
            n1 = n2;
            n2 = n3;
            n3 = sum;
        }
        Console.WriteLine(sum);
    }
}