/*Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following: */

using System;

class ReadNPrintMatrixNxN
{
    static void Main()
    {
        Console.Write("Please enter positive integer N < 20: N = ");
        string Nstr = Console.ReadLine();
        byte N = byte.Parse(Nstr);
        for (int i = 1; i <= N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i + j < 10)
                {
                    Console.Write((i + j) + " ");
                }
                else
                {
                    Console.Write((i + j) + "");
                }
            }
            Console.WriteLine();
        }
    }
}