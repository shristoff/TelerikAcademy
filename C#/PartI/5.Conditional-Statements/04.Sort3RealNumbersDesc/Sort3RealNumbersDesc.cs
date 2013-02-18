/*Sort 3 real values in descending order using nested if statements.*/

using System;
using System.Threading;
using System.Globalization;

class Sort3RealNumbersDesc
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        float a = 3.9f;
        float b = 7.4f;
        float c = 5.4f;
        if (a >= b)
        {
            if (b >= c) //a>=b b>=c
            {
                Console.WriteLine("{0}\n{1}\n{2}\n", a, b, c);
            }
            else if (a >= c) //a>=c a>=b c>b 
            {
                Console.WriteLine("{0}\n{1}\n{2}\n", a, c, b);
            }
            else if (a < c) //a>=b c>b c>a
            {
                Console.WriteLine("{0}\n{1}\n{2}\n", c, a, b);
            }
        }
        else  //b>a 
        {
            if (a >= c) //b>a a>=c
            {
                Console.WriteLine("{0}\n{1}\n{2}\n", b, a, c);
            }
            else if (b >= c) //b>a b>=c c>a
            {
                Console.WriteLine("{0}\n{1}\n{2}\n", b, c, a);
            }
            else if (b < c) //b>a c>a c>b
            {
                Console.WriteLine("{0}\n{1}\n{2}\n", c, b, a);
            }
        }
    }
}