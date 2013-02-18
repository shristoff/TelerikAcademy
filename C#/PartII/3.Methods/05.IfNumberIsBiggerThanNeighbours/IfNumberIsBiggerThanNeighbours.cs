/* Write a method that checks if the element at given position in given array of integers is bigger 
than its two neighbors (when such exist). */

using System;

public class IfNumberIsBiggerThanNeighbours
{
    public static bool CheckNumberInArr(int[] arr, int index)
    {
        bool biggerThanNeighbours = false;
        if (arr.Length != 1)
        {
            if (index == 0)
            {
                if (arr[0] > arr[1])
                    return biggerThanNeighbours = true;
                else
                    return biggerThanNeighbours;
            }
            else if (index == arr.Length - 1 && arr[index] > arr[index - 1])
                return biggerThanNeighbours = true;
            else if (index < arr.Length - 1 && arr[index - 1] < arr[index] && arr[index + 1] < arr[index])
                biggerThanNeighbours = true;
        }
        else
            return biggerThanNeighbours = true;
        return biggerThanNeighbours;
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
        Console.WriteLine("Please enter the index of the number you want to be checked: ");
        int index = int.Parse(Console.ReadLine());
        if (CheckNumberInArr(arr, index))
            Console.WriteLine("The numbers is bigger than its neghbours.");
        else
            Console.WriteLine("The numbers is NOT bigger than its neghbours.");
    }
}