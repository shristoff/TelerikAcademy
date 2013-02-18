using System;

class CheckIf3rdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Please enter at least 3-digit integer number: ");
        int num = int.Parse(Console.ReadLine());
        int num100 = num / 100;
        int num1000 = num100 % 10;
        bool CheckFor7 = (num1000 == 7);
        Console.WriteLine("\"The third digit from right to left is 7\" is: {0}", CheckFor7);
    }
}