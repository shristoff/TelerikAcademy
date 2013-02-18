/* Write a method that returns the last digit of given integer as an English word. 
 Examples: 512  "two", 1024  "four", 12309  "nine".*/

using System;

class WriteLastDigitAsWord
{
    static string LastDigitToWord(int number)
    { 
        string digitToWord;
        int lastDigit = number % 10;
        switch (lastDigit)
        {
            case 1: digitToWord = "one"; break;
            case 2: digitToWord = "two"; break;
            case 3: digitToWord = "three"; break;
            case 4: digitToWord = "four"; break;
            case 5: digitToWord = "five"; break;
            case 6: digitToWord = "six"; break;
            case 7: digitToWord = "seven"; break;
            case 8: digitToWord = "eight"; break;
            case 9: digitToWord = "nine"; break;
            default: digitToWord = "zero"; break;
        }
        return digitToWord;
    }

    static void Main()
    {
        Console.WriteLine("Pease enter integer number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit is: {0}", LastDigitToWord(num));
    }
}