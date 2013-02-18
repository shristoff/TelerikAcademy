/*Write a program that finds the greatest of given 5 variables.*/

using System;

class FindTheBiggestOf5Nums
{
    static void Main()
    {
        int n1 = 14;
        int n2 = 13;
        int n3 = 23;
        int n4 = 2;
        int c = 11; //n5
        int a = Math.Max(n1, n2);
        int b = Math.Max(n3, n4);
        int max = 0;
        if (a >= b) //povtariame reshenieto na zadachata za 3 chisla
        {
            if ((b >= c) || (a >= c))
            {
                max = a;
            }
            else //a>=b (b<c or a<c)
            {
                max = c;
            }
        }
        else //a < b
        {
            if ((b >= c) || (a >= c))
            {
                max = b;
            }
            else //b<c i a<c
            {
                max = c;
            }
        }
        Console.WriteLine(max);
    }
}