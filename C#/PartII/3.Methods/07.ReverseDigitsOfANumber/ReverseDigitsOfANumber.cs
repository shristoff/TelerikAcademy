/* Write a method that reverses the digits of given decimal number. Example: 256  652 */

using System;

public class ReverseDigitsOfANumber
{
    public static string ReverseDigits(string num)
    {
        string reversed = "";
        for (int i = num.Length - 1; i >= 0; i--)
        {
            if (i == 0 && num[0] == '-')
            {
                reversed = reversed.Insert(0, "-");
                break;
            }
            reversed = reversed.Insert(num.Length - i - 1, num[i].ToString());
        }
        return reversed;
    }

    static void Main()
    {
        Console.WriteLine("Please enter decimal number: ");
        string num = Console.ReadLine();
        Console.WriteLine(ReverseDigits(num));
    }
}