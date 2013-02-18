using System;
using System.Threading;
using System.Globalization;

class ReadRPrintAreaPer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter the radius of the circle r = ");
        float r = float.Parse(Console.ReadLine());
        float S = (float) Math.PI * r * r;
        float P = (float) Math.PI * 2 * r;
        Console.WriteLine("The area of the circle is: {0}, the perimeter of the circle is: {1}", S, P);
    }
}
