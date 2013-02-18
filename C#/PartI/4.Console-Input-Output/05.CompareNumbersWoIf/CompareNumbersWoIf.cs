using System;
using System.Threading;
using System.Globalization;

class ReadRPrintAreaPer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter number a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Please enter number b = ");
        float b = float.Parse(Console.ReadLine());
        float greaterAB = (float)Math.Max(a, b);
        Console.WriteLine("The bigger number is: {0}", greaterAB);
    }
}