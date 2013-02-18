/*Write a program that finds the biggest of three integers using nested if statements.*/

using System;

class FindTheBiggestOf3Nums
{
    static void Main()
    {
        int a = 39;
        int b = 34;
        int c = 14;
        int max = 0;
        if (a >= b)
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