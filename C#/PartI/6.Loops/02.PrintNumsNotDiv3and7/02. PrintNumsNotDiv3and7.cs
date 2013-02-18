/* Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.*/

using System;

class PrintNumsNotDiv3and7
{
    static void Main()
    {
        Console.Write("Please enter positive integer N = ");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        int i = 0;
        while (i <= N)
        {
            if (i % 21 != 0)
            {
                Console.WriteLine(i);
                i++;
            }
            else
            i++;
        }
    }
}