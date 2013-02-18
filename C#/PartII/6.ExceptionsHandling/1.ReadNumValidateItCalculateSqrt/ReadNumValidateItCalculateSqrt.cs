/*Write a program that reads an integer number and calculates and prints its square root. 
If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.*/

using System;

class ReadNumValidateItCalculateSqrt
{
    static double CalculateSqrt(int num)
    {
        if (num < 0)
            throw new ArithmeticException();
        return Math.Sqrt(num);
    }

    static void Main()
    {
        Console.WriteLine("Please enter positive integer: ");
        try
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateSqrt(num));
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
        catch (ArithmeticException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
