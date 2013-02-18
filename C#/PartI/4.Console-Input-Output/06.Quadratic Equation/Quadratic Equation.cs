using System;
using System.Threading;
using System.Globalization;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter number a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Please enter number b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Please enter number c = ");
        float c = float.Parse(Console.ReadLine());
        float D = b * b - 4 * a * c;
        if (a == 0 && b == 0 && c == 0)
        {
            Console.WriteLine("The number of real roots is infinity");
        }
        else if (a == 0 && b == 0 && c != 0)
        {
            Console.WriteLine("There are no any real roots");
        }
        else if (a == 0 && b != 0)
        {
            float x1 = -(c / b);
            Console.WriteLine("The equation is linear. The real root is: {0}", x1);
        }
        else if (D >= 0)
        {
            float x1 = (float)(0.5 * (-b - Math.Sqrt(D)) / a);
            float x2 = (float)(0.5 * (-b + Math.Sqrt(D)) / a);
            Console.WriteLine("The real roots are: {0} and {1}", x1, x2);
        }
        else
        {
            Console.WriteLine("There are no any real roots");
        }
    }
}
