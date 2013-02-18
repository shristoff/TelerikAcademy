/* Write a program to convert hexadecimal numbers to their decimal representation.*/

using System;
using System.Numerics;

public class HexadecimalToDecimal
{
    public static BigInteger ConvertHexadecimalToDecimal(string hexNum)
    {
        BigInteger num = 0;
        byte i = 0;
        while (i < hexNum.Length)
        {
            string hexChar = hexChar = hexNum[hexNum.Length - i - 1].ToString(); 
            switch (hexChar)
            {
                case "F": hexChar = "15"; break;
                case "E": hexChar = "14"; break;
                case "D": hexChar = "13"; break;
                case "C": hexChar = "12"; break;
                case "B": hexChar = "11"; break;
                case "A": hexChar = "10"; break;
            }
            num = num + byte.Parse(hexChar) * ((BigInteger)1 << 4*i);
            i++;
        }
        return num;
    }

    static void Main()
    {
        Console.WriteLine("Please enter the number you want to convert to decimal numeral system: ");
        string hexNum = Console.ReadLine();
        Console.WriteLine(ConvertHexadecimalToDecimal(hexNum));
        Console.WriteLine(DecimalToHexadecimal.ConvertDecimalToHexadecimal(ConvertHexadecimalToDecimal(hexNum)));  //Calling the method
    }                                                                               //from the previuos problem for check
}