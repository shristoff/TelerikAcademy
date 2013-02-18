/* Write a program to convert binary numbers to hexadecimal numbers (directly).*/

using System;
using System.Numerics;

public class BinaryToHexadecimal
{
    public static string ConvertBinaryToHexadecimal(string binary)
    {
        string hexNum = "";
        string hexChar = "";
        byte i = 0, remainder = 0; 
        int num = 0;
        while (4 * i + 4 <= binary.Length)
        {
            hexChar = binary.Substring(binary.Length - 4*i - 4, 4);
            switch (hexChar)
            {
                case "1111": hexChar = "F"; break;
                case "1110": hexChar = "E"; break;
                case "1101": hexChar = "D"; break;
                case "1100": hexChar = "C"; break;
                case "1011": hexChar = "B"; break;
                case "1010": hexChar = "A"; break;
                case "1001": hexChar = "9"; break;
                case "1000": hexChar = "8"; break;
                case "0111": hexChar = "7"; break;
                case "0110": hexChar = "6"; break;
                case "0101": hexChar = "5"; break;
                case "0100": hexChar = "4"; break;
                case "0011": hexChar = "3"; break;
                case "0010": hexChar = "2"; break;
                case "0001": hexChar = "1"; break;
                case "0000": hexChar = "0"; break;
            }
            if (binary == "0")
                hexNum = "0";
            hexNum = hexNum.Insert(0, hexChar);
            i++;
        }
        remainder = (byte)(binary.Length & 3);
        i = remainder;
        while (i > 0)
        {
            hexChar = binary.Substring(i - 1, 1);
            num = num + int.Parse(hexChar) * (1 << (remainder - i));
            i--;
        }
        hexNum = hexNum.Insert(0, num.ToString());
        return hexNum;
    }

    static void Main()
    {
        Console.WriteLine("Please enter the number you want to convert to binary numeral system: ");
        string binary = Console.ReadLine();
        Console.WriteLine(ConvertBinaryToHexadecimal(binary));
        Console.WriteLine(HexadecimalToBinary.ConvertHexadecimalToBinary(ConvertBinaryToHexadecimal(binary)));//Calling the method
    }                                                                                       //from the previuos problem for check
}