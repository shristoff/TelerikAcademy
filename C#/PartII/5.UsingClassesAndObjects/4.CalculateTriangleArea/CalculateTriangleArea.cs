/* Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math. */

using System;

class TriangleArea
{
    static decimal CalculateTriangleArea(decimal a, decimal ha)
    {
        decimal s = a * ha / 2;
        return s;
    }

    static double CalculateTriangleArea(decimal a, decimal b, decimal c)
    {
        double s = (double)((a + b + c) * (a + b) * (b + c) * (a + c));
        return Math.Sqrt(s);
    }

    static double CalculateTriangleArea(double a, double b, int angleab)
    {
        double s = a * b * Math.Sin((double)(angleab * Math.PI / 180));
        return s;
    }

    static void Main()
    {
        Console.WriteLine(" 1.Calaculate triangle area by side and altitude to it.");
        Console.WriteLine(" 2.Calculate triangle area by three sides.");
        Console.WriteLine(" 3.Calculate triangle area by two sides and angle (in degrees) between them.");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1": Console.WriteLine("Please enter side and altitude to it:");
                decimal d = decimal.Parse(Console.ReadLine()); 
                decimal hd = decimal.Parse(Console.ReadLine());
                Console.WriteLine("The area is: {0}", CalculateTriangleArea(d, hd));break;
            case "2": Console.WriteLine("Please enter three sides:");
                decimal x = decimal.Parse(Console.ReadLine()); 
                decimal y = decimal.Parse(Console.ReadLine()); 
                decimal z = decimal.Parse(Console.ReadLine()); 
                Console.WriteLine("The area is: {0}", CalculateTriangleArea(x, y, z));break;
            case "3": Console.WriteLine("Please enter two sides and angle between them:");
                double a = double.Parse(Console.ReadLine()); 
                double b = double.Parse(Console.ReadLine()); 
                int alpha = int.Parse(Console.ReadLine()); 
                Console.WriteLine("The area is: {0}", CalculateTriangleArea(a, b, alpha));break;
            default: Console.WriteLine("Try again - it is easy - 1, 2 or 3!"); break;
        }
    }
}
