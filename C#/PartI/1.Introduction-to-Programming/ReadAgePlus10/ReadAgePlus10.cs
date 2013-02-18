using System;

class ReadAgePlus10
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be {0} years old!",age+10);
    }
}