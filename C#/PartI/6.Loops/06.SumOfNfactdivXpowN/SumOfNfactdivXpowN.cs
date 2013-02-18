/* Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN. */

using System;

class SumOfNfactdivXpowN
{
    static void Main()
    {
        Console.Write("Please enter positive integer N = ");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        Console.Write("Please enter an integer X = ");
        string Xstr = Console.ReadLine();
        int X = int.Parse(Xstr);
        double fact = 1;
        double S = 1;
        double XpowN = 1;
        for (int i = 1; i <= N; i++)
        {
            fact *= i;
            XpowN *= X;
            S += fact / XpowN;
            if (fact > double.MaxValue || XpowN > double.MaxValue)
            {
                break;
            }
        }
        Console.WriteLine("1 + 1!/X + 2!/X2 + 3!/X3... + N!/XN = {0}", S);
    }
}
