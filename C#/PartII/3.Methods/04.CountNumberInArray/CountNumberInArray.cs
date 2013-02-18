/* Write a method that counts how many times given number appears in given array. 
 Write a test program to check if the method is working correctly. */

using System;

class CountNumberInArray
{
    static int CountNumberInArr(int[] arr, int numberToCount)
    {
        int i = 0, count = 0;
        while (i < arr.Length)
        {
            if (arr[i] == numberToCount)
                count++;
            i++;
        }
        return count;
    }

    static void Main()
    {
        int i = 0; 
        Console.WriteLine("Please enter the array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Please enter the array numbers: ");
        while (i < n)
        {
            arr[i] = int.Parse(Console.ReadLine());
            i++;
        }
        Console.WriteLine("Please enter the number you want to be counted: ");
        int numberToCount = int.Parse(Console.ReadLine());
        Console.WriteLine("The number {0} repeats {1} time(s)", numberToCount, CountNumberInArr(arr, numberToCount));
    }
}
