using System;

class CheckIfNumberIsPrime
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int num = int.Parse(Console.ReadLine());
        int sqrt = (int)Math.Sqrt(num);
        int i = 2;
        bool prime = true;
        while (prime && i <= sqrt)
        {
            if (num % i == 0)
            {
                prime = false;
            }
            i++;
        }
        if (!prime)
        {
            Console.WriteLine("The number is composite!");
        }
        if (prime)
        {
            Console.WriteLine("The number is prime!");
        }
    }
}