/* Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
 * Modify your program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.).
Use generic method (read in Internet about generic methods in C#). */

using System;

class CalcMinMaxAverSumProduct
{
    static T Minimum<T>(params T[] arr)
    {
        dynamic minNum = 0;
        bool smallest = false;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                smallest = (dynamic)arr[i] <= arr[j];
                if (!smallest)
                    break;
            }
            if (smallest)
                minNum = arr[i];
        }
        return minNum;
    }

    static T Maximum<T>(params T[] arr)
    {
        dynamic maxNum = 0;
        bool biggest = false;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                biggest = (dynamic)arr[i] >= arr[j]; 
                if (!biggest)          
                    break;             
            }
            if (biggest)               
                maxNum = arr[i];       
        }
        return maxNum;
    }

    static T Average<T>(params T[] arr)
    {
        int i = 0;
        dynamic sum = 0, average = 0;
        while (i < arr.Length)
        {
            sum = sum + arr[i];
            i++;
        }
        average = sum / arr.Length;
        return average;
    }

    static T Sum<T>(params T[] arr)
    {
        dynamic sum = 0;
        foreach (T num in arr)
            sum = sum + num;
        return sum;
    }

    static T Product<T>(params T[] arr)
    {
        dynamic product = 1;
        foreach (dynamic num in arr)
            product = product * num;
        return product;
    }

    static void Main()
    {
        Console.WriteLine("\n Minimum is: {0}", Minimum(0, 1.45, 34, -12.34, 3, 9, 1)); //double
        Console.WriteLine(" Maximum is: {0}", Maximum(18, -12.02d, 724.345d, -12.23d, 3, 9, 1.29d, 123));  //double
        Console.WriteLine(" Average is: {0}", Average(20.34m, 120, -34, -12, 321, 9, 1.3453m, 123.325m, 45, 64, 23, 129, 9430, -1234)); //decimal
        Console.WriteLine(" The Sum is: {0}", Sum(4.23f, 1, 34, -12, 3.57f, 9, 1, 398.232f, -234, 1));  //float
        Console.WriteLine(" Product is: {0}\n", Product(78, 1, 24.25434d));  //double
    }
}
