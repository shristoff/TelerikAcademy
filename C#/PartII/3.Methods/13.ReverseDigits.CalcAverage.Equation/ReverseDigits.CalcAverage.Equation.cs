/* Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
            The decimal number should be non-negative
            The sequence should not be empty
            a should not be equal to 0 */

using System;

class ReverseDigitsCalcAverageEquation
{
    static void ReadNumberAndReverseDigits()
    {
        string num;
        do
        {
            Console.WriteLine("Please enter positive decimal number: ");
            num = Console.ReadLine();
        }
        while (num[0] == '-');
        Console.WriteLine(ReverseDigitsOfANumber.ReverseDigits(num));
    }

    static void CalculateAverageOfIntegers()
    {
        int n, i = 0;
        do
        {
            Console.WriteLine("Enter the number of integers that you want the average: ");
            string nStr = Console.ReadLine();
            n = int.Parse(nStr);
        }
        while (n <= 0);
        decimal sum = 0, average = 0;
        decimal[] arr = new decimal[n];
        Console.WriteLine("Please enter the numbers:");
        while (i < n)
        {
            string numStr = Console.ReadLine();
            arr[i] = decimal.Parse(numStr);
            sum = sum + arr[i];
            i++;
        }
        average = (decimal)(sum / n);
        Console.WriteLine("The average is: {0}", average);
    }

    static void SolveLinearEquation()
    {
        string aStr;
        decimal a;
        do
        {
            Console.WriteLine("Your equation is ax + b = 0. Please enter a != 0 and b: ");
            aStr = Console.ReadLine();
            a = decimal.Parse(aStr);
        }
        while (a == 0);
        string bStr = Console.ReadLine();
        decimal b = decimal.Parse(bStr);
        decimal x = -b / a;
        Console.WriteLine("x = {0}", x);
    }
    
    static void Main()
    {
        byte userChoice;
        Console.WriteLine("Please enter your choice: ");
        do
        {
            Console.WriteLine(" 1.Reverse digits of a number \n 2.Calculate the average of integers \n 3.Solve linear equation");
            userChoice = byte.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1: ReadNumberAndReverseDigits(); break;
                case 2: CalculateAverageOfIntegers(); break;
                case 3: SolveLinearEquation(); break;
                default: Console.WriteLine("Wrong choice! Try your luck again by pressing 1, 2 or at least 3!\n"); break;
            }
        }
        while (userChoice < 1 || userChoice > 3);
    }
}
