/* Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short). */

using System;

class SignedShortToBinary
{
    static string ConvertShortToBinary(short num)
    {
        string binary = "";
        byte bit, bitPosition = 0;
        bool Positive = true;
        if (num < 0)
        {
            Positive = false;
            num = (short)(num & (~(1 << 15)));
            while (num >= 0)
            {
                bit = (byte)(num & 1);
                string bitStr = bit.ToString();
                binary = binary.Insert(0, bitStr);
                num = (short)(num >> 1);
                if (num == 0)
                    break;
                bitPosition++;
            }
            while (bitPosition < 14)
            {
                binary = binary.Insert(0, "0");
                bitPosition++;
            }
            binary = binary.Insert(0, "1");
        }
        if (Positive)
        {
            while (num >= 0)
            {
                bit = (byte)(num & 1);
                string bitStr = bit.ToString();
                binary = binary.Insert(0, bitStr);
                num = (short)(num >> 1);
                if (num == 0)
                    break;
            }
        }
        return binary;
    }

    static void Main()
    {
        Console.WriteLine("Please enter the number you want to convert to binary numeral system: ");
        short num = short.Parse(Console.ReadLine());
        Console.WriteLine(ConvertShortToBinary(num));
        Console.WriteLine(Convert.ToString(num, 2));  //for check
    }
}
