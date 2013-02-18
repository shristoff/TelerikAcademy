/* Write a method GetMax() with two parameters that returns the bigger of two integers. 
Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

using System;

class GetMaxOfTwoIntMethod
{
    static int firstNum;
    static int secondNum;
    static int thirdNum;
 
    static int GetMax(int first, int second)
    {
        int bigger = first;
        if (bigger < second)
            bigger = second;
        return bigger;
    }

    static void Main()
    {
        Console.WriteLine("Pease enter 3 integer numbers: ");
        firstNum = int.Parse(Console.ReadLine());
        secondNum = int.Parse(Console.ReadLine());
        thirdNum = int.Parse(Console.ReadLine());
        Console.WriteLine("The biggest number is: {0}", GetMax(thirdNum, GetMax(firstNum, secondNum)));
    }
}
