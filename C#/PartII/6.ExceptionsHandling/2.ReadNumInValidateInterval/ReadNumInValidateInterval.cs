/* Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
If an invalid number or non-number text is entered, the method should throw an exception. 
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100 */

using System;
using System.Linq;

class ReadNumInValidateInterval
{
    static int ReadNumber(int start, int end)
    {
        int num = 0;
        Console.WriteLine("Please enter an integer number between {0} and {1}: ", start, end);
        try
        {
            num = int.Parse(Console.ReadLine());
            if (num < start || num > end)
                throw new ArgumentOutOfRangeException();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number");
        }
        return num;
    }

    static void Main()
    {
        int[] arr = new int[10];
        int ai = ReadNumber(1, 100);
        for (int i = 1; i < 10; i++)
        {
            ai = ReadNumber(ai + 1, 100);
            arr[i] = ai;
        }
    }
}
