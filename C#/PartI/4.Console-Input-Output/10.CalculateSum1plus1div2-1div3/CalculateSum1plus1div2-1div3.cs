using System;

class ReadNAndSumNnumbers
{
    static void Main()
    {
        int i = 2;
        double oldSum, newSum = 1;
        sbyte sign = 1;
        do
        {
            oldSum = newSum;
            if (i % 2 == 0)
            {
                sign = 1;
            }
            else
            {
             sign = -1;
            }
            newSum = newSum + sign * 1.0 / i;
            i++;
        } 
        while (Math.Abs(newSum - oldSum) >= 0.001);
        Console.WriteLine("The sum of first n numbers in the row 1, 1/2, -1/3, 1/4...is: {0}", newSum);
    }
}