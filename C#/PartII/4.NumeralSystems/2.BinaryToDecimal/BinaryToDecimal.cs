/* Write a program to convert binary numbers to their decimal representation.*/

using System;
using System.Numerics;

public class BinaryToDecimal
{
    public static BigInteger ConvertBinaryToDecimal(string binNum)
    {
        BigInteger num = 0;
        byte i = 0;
        while (i < binNum.Length)
        {
            num = num + byte.Parse(binNum[binNum.Length - i - 1].ToString()) * ((BigInteger)1 << i);
            i++;
        }
        return num;
    }

    static void Main()
    {
        Console.WriteLine("Please enter the number you want to convert to decimal numeral system: ");
        string binNum = Console.ReadLine();
        Console.WriteLine(ConvertBinaryToDecimal(binNum));
        //Console.WriteLine(Convert.ToInt64(binNum, 2).ToString());  //to check
    }
}
