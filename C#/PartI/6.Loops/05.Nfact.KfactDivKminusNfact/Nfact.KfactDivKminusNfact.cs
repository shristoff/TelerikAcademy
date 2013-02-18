/* Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K). */

using System;

class NfactKfactDivKminusNfact
{
    static void Main()
    {
        Console.Write("Please enter positive integer N = ");
        string Nstr = Console.ReadLine();
        ulong N = ulong.Parse(Nstr);
        Console.Write("Please enter positive integer K > N: K = ");
        string Kstr = Console.ReadLine();
        ulong K = ulong.Parse(Kstr);
        ulong productNK = 1;
        ulong Nfact = 1;
        for (ulong i = (K - N) + 1; i <= K; i++)
        {
            productNK *= i;
        }
        for (ulong i = 2; i <= N; i++)
        {
            Nfact *= i;
        }
        Console.WriteLine("N!*K! / (K - N)! = {0}", (productNK * Nfact));
    }
}