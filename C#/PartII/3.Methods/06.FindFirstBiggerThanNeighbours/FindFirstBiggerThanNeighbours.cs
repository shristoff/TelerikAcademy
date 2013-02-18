/*Write a method that returns the index of the first element in array that is bigger than its neighbors, 
or -1, if there’s no such element. Use the method from the previous exercise. */

using System;

class FindFirstBiggerThanNeighbours
{
    static void Main()
    {
        int i = 0;
        bool foundNumber = false;
        Console.WriteLine("Please enter the array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Please enter the array numbers: ");
        while (i < n)
        {
            arr[i] = int.Parse(Console.ReadLine());
            i++;
        }
        for (i = 0; i < arr.Length; i++)
        {
            if (IfNumberIsBiggerThanNeighbours.CheckNumberInArr(arr, i))
            {
                Console.WriteLine("The index of the first number is: {0}", i);
                foundNumber = true;
                break;
            }
        }
        if (!foundNumber)
            Console.WriteLine(-1);
    }
}
