/* Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).*/

using System;
using System.Numerics;
using System.Globalization;

class FromAnyNumeralSystemToAny216
{
    static BigInteger ConvertToDecimal(byte s, string snum)
    {
        BigInteger num = 0, power = 1;
        byte i = 0;
        string sNum = snum.ToString();
        if (s <= 10)
        {
            while (i < sNum.Length)
            {
                num = num + byte.Parse(sNum[sNum.Length - i - 1].ToString()) * power;
                power = power * s;
                i++;
            }
        }
        if (s > 10)
        {
            while (i < sNum.Length)
            {
                string sChar = sChar = sNum[sNum.Length - i - 1].ToString();
                switch (sChar)
                {
                    case "F": sChar = "15"; break;
                    case "E": sChar = "14"; break;
                    case "D": sChar = "13"; break;
                    case "C": sChar = "12"; break;
                    case "B": sChar = "11"; break;
                    case "A": sChar = "10"; break;
                }
                num = num + byte.Parse(sChar) * power;
                power = power * s;
                i++;
            }
        }
        return num;
    }

    static string ConvertDecimalToAnyNumeralSystem(byte d, BigInteger num)
    {
        string result = "", remainderStr;
        byte bit, remainder;
        if (d <= 10)
        {
            while (num >= 0)
            {
                bit = (byte)(num % d);
                string bitStr = bit.ToString();
                result = result.Insert(0, bitStr);
                num = num / d;
                if (num == 0)
                    break;
            }
        }
        if (d > 10)
        {
            while (num >= 0)
            {
                remainder = (byte)(num % d);
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
                result = result.Insert(0, remainderStr);
                num = num / d;
                if (num == 0)
                    break;
            }
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Please enter s and d:");
        byte s = byte.Parse(Console.ReadLine());
        byte d = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number in numeral system with base {0}:", s);
        string sNum = Console.ReadLine();
        Console.Write("Your number in numeral system with base {0} is: ", d);
        Console.WriteLine(ConvertDecimalToAnyNumeralSystem(d, ConvertToDecimal(s, sNum)));
    }
}
