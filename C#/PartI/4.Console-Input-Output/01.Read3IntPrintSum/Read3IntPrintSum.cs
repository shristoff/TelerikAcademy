using System;

class Read3IntPrintSum
{
    static void Main()
    {
        Console.Write("Please enter the first integer a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter the first integer b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Please enter the first integer c = ");
        int c = int.Parse(Console.ReadLine());
        int sum = a + b + c;
        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}
