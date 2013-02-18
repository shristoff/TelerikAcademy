/*In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
Write a program to calculate the Nth Catalan number by given N.*/

using System;

class PrintNthCatalanNumber
{
    static void Main()
    {
        Console.Write("Please enter positive integer N = ");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        double factNto2N = 1;
        double fact1toNplus1 = 1;
        double CathalanNum = 1;
        for (int i = N + 1, j = 2; i <= 2*N; i++, j++)
        {
            factNto2N = factNto2N * i;
            fact1toNplus1 = fact1toNplus1 * j;
            CathalanNum = factNto2N / fact1toNplus1;
        }
        Console.WriteLine("(2N)!/N!(N+1)! = {0}/{1} = {2}", factNto2N, fact1toNplus1, CathalanNum);
    }
}