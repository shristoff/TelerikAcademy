/* Write a program to convert decimal numbers to their binary representation.*/

using System;
using System.Numerics;

class DecimalToBinary
{
    static string ConvertDecimalToBinary(BigInteger num)
    { 
        string binary = "";
        byte bit;
        while (num >= 0)
        {
            bit = (byte)(num & 1);
            string bitStr = bit.ToString();
            binary = binary.Insert(0, bitStr);
            num = num >> 1;
            if (num == 0)
                break;
        }
        return binary; 
    }

    static void Main()
    {
        Console.WriteLine("Please enter the number you want to convert to binary numeral system: ");
        BigInteger num = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecimalToBinary(num));
        Console.WriteLine(BinaryToDecimal.ConvertBinaryToDecimal(ConvertDecimalToBinary(num)));  //Calling the method 
    }                                                                               //from the next problem for check
}
