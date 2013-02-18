using System;

class CompareFPNumbers
{
    static void Main()
    {
        Console.Write("Enter a real number: a=");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Enter a real number: b=");
        decimal b = decimal.Parse(Console.ReadLine());
        if (Math.Abs(a - b) < 0.000001m)
        {
            Console.WriteLine("a=b (6 digit precision)");
        }
        else
            Console.WriteLine("a != b");
    }
}