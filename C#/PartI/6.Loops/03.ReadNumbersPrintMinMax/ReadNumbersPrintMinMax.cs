/* Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them. */

using System;
using System.Threading;
using System.Globalization;

class ReadNumbersPrintMinMax
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter positive integer n = ");
        string nstr = Console.ReadLine();
        int n = int.Parse(nstr);
        int i = 1;
        float min = 1/0f;
        float max = -1/0f;
        do
        {
            Console.Write("Please enter a real number r{0} = ", i);
            string ristr = Console.ReadLine();
            float ri = float.Parse(ristr);
            if (ri <= min)
            {
                min = ri;
            }
            if (ri >= max)
            {
                max = ri;
            }
            i++;
        }
        while (i <= n);
        Console.WriteLine("The smallest and the biggest numbers are: min = {0}, max = {1}", min, max);
    }
}