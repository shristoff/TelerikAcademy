/* Write a program that calculates N!/K! for given N and K (1<K<N).*/

using System;

class NfactdivKfact
{
    static void Main()
    {
        Console.Write("Please enter positive integer N = ");
        string Nstr = Console.ReadLine();
        ulong N = ulong.Parse(Nstr);
        Console.Write("Please enter positive integer K < N: K = ");
        string Kstr = Console.ReadLine();
        ulong K = ulong.Parse(Kstr);
        ulong fact = 1;
        for (ulong i = K + 1; i <= N; i++)
        {
            fact *= i;
        }
        Console.WriteLine("N!/K! = {0}", fact);
    }
}