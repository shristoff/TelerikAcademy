using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Please enter the height of the trapezoid h=");
        float h = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the side of the trapezoid a=");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the side of the trapezoid b=");
        float b = float.Parse(Console.ReadLine());
        float area = 0.5f * h * (a + b);
        Console.WriteLine("The area is: {0}", area);
    }
}