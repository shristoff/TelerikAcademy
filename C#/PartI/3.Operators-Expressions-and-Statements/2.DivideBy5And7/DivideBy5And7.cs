using System;

class DivideBy5And7
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer number: ");
        int n = int.Parse(Console.ReadLine());
        bool FiveAndSeven = (n % 35 == 0);
        Console.WriteLine("\"The number divides by 5 and by 7 (or by 35)\" is: {0}", FiveAndSeven);
    }
}