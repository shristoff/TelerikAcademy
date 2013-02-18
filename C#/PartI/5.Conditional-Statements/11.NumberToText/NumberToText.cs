/* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
 Examples:
	0  "Zero"
	273  "Two hundred seventy three"
	400  "Four hundred"
	501  "Five hundred and one"
	711  "Seven hundred and eleven"*/

using System;

class NumberToText
{
    static string[] Ones = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", 
                               "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
    static string[] ones = { "\b ", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", 
                               "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
    static string[] Tens = { "", "", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
    static string[] tens = { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

    static int Readn()
    {
        Console.Write("Please enter number between 0 and 999: ");
        int n = int.Parse(Console.ReadLine());
        return n;
    }

    static void OneNineteen(int n)
    {
        if (n >= 0 && n <= 19)
        {
            Console.WriteLine(Ones[n]);
        }
    }

    static void TwentyNineHundred(int n)
    {
        if (n >= 20 && n <= 99)
        {
            Console.WriteLine(Tens[(n / 10)]);
            Console.SetCursorPosition(Tens[(n / 10)].Length, Console.CursorTop - 1);
            Console.WriteLine("-" + ones[n % 10]);
        }
        if (n >= 100)
        {
            OneNineteen(n / 100);
            if ((n % ((n / 100)*100) <= 19) && (n % ((n / 100)*100) >= 1))
            {
                Console.SetCursorPosition(Ones[n / 100].Length, Console.CursorTop - 1);
                Console.Write(" hundred and ");
                Console.WriteLine(ones[n - (n / 100) * 100]);
            }
            if ((n % ((n / 100)*100) == 0) || (n % ((n / 100)*100) >= 20) && (n % ((n / 100)*100) <= 99))
            {
                Console.SetCursorPosition(Ones[(n / 100)].Length, Console.CursorTop - 1);
                Console.Write(" hundred ");
                Console.Write(tens[((n / 10) % 10)]);
                Console.WriteLine(" " + ones[n % 10]);
            }
        }
    }

    static void Main()
    {
        int n = Readn();
        OneNineteen(n);
        TwentyNineHundred(n);
    }
}
