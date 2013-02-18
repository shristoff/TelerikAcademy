/* Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
 percentage and in scientific notation. Format the output aligned right in 15 symbols. */

using System;

class PrintNumAsDecHexPercSci
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        string numStr = Console.ReadLine();
        int num = int.Parse(numStr);
        Console.WriteLine("Dec {0,15:D}", num);
        Console.WriteLine("Hex {0,15:X}", num);
        Console.WriteLine("Per {0,15:P}", num);
        Console.WriteLine("Sci {0,15:E}", num);
    }
}