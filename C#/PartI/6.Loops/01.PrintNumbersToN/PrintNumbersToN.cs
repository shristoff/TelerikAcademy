/*Write a program that prints all the numbers from 1 to N. */

using System;

class PrintNumbersToN
{
    static void Main()
    {
        Console.Write("Please enter positive integer N = ");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        int i = 0;
        while (i <= N)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}