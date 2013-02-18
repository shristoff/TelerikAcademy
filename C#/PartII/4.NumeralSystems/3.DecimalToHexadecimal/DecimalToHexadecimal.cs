/*Write a program to convert decimal numbers to their hexadecimal representation. */

using System;
using System.Numerics;

public class DecimalToHexadecimal
{
    public static string ConvertDecimalToHexadecimal(BigInteger num)
    {
        string hex = "", remainderStr;
        byte remainder;
        while (num >= 0)
        {
            remainder = (byte)(num & 15);
            switch (remainder)
            {
                case 10: remainderStr = "A"; break;
                case 11: remainderStr = "B"; break;
                case 12: remainderStr = "C"; break;
                case 13: remainderStr = "D"; break;
                case 14: remainderStr = "E"; break;
                case 15: remainderStr = "F"; break;
                default: remainderStr = remainder.ToString(); break;
            }
            hex = hex.Insert(0, remainderStr);
            num = num >> 4;
            if (num == 0)
                break;
        }
        return hex;
    }

    static void Main()
    {
        Console.WriteLine("Please enter the number you want to convert to binary numeral system: ");
        BigInteger num = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecimalToHexadecimal(num));
    }
}