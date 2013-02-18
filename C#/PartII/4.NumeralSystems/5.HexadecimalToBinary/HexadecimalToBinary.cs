/* Write a program to convert hexadecimal numbers to binary numbers (directly).*/

using System;
using System.Numerics;

public class HexadecimalToBinary
{
    public static string ConvertHexadecimalToBinary(string hexNum)
    {
        string binary = "";
        byte i = 0;
        while (i < hexNum.Length)
        {
            string hexChar = hexNum[hexNum.Length - i - 1].ToString();
            switch (hexChar)
            {
                case "F": hexChar = "1111"; break;
                case "E": hexChar = "1110"; break;
                case "D": hexChar = "1101"; break;
                case "C": hexChar = "1100"; break;
                case "B": hexChar = "1011"; break;
                case "A": hexChar = "1010"; break;
                case "9": hexChar = "1001"; break;
                case "8": hexChar = "1000"; break;
                case "7": hexChar = "0111"; break;
                case "6": hexChar = "0110"; break;
                case "5": hexChar = "0101"; break;
                case "4": hexChar = "0100"; break;
                case "3": hexChar = "0011"; break;
                case "2": hexChar = "0010"; break;
                case "1": hexChar = "0001"; break;
                case "0": hexChar = "0000"; break;
            }
            if (i == hexNum.Length - 1)
            {
                    switch(hexChar)
                {
                    case "0111": hexChar = "111"; break;
                    case "0110": hexChar = "110"; break;
                    case "0101": hexChar = "101"; break;
                    case "0100": hexChar = "100"; break;
                    case "0011": hexChar = "11"; break;
                    case "0010": hexChar = "10"; break;
                    case "0001": hexChar = "1"; break;
                    case "0000": hexChar = ""; break;
                }
            }
            if (hexNum == "0")
                hexChar = "0";
            binary = binary.Insert(0, hexChar);
            i++;
        }
        return binary;
    }

    static void Main()
    {
        Console.WriteLine("Please enter the number you want to convert to binary numeral system: ");
        string hexNum = Console.ReadLine();
        Console.WriteLine(ConvertHexadecimalToBinary(hexNum));
    }                                                                             
}