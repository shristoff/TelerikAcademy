using System;

class EvenOrOddCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer number: ");
        int n = int.Parse(Console.ReadLine());
        bool even = (n % 2 == 0);
        Console.WriteLine("\"The number is even\" is: {0}", even);
        Console.WriteLine("\"The number is odd\" is: {0}", !even);
    }
}