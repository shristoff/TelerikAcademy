/*Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/

using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array:");
        string Lengthstr = Console.ReadLine();
        int Length = int.Parse(Lengthstr);
        int i = 0, sequence = 1, count = 1;
        int[] Arr = new int[Length];
        while (i < Length)
        {
            Console.WriteLine("Please enter the {0} number of the array", i + 1);
            string Numstr = Console.ReadLine();
            Arr[i] = int.Parse(Numstr);
            if (i >= 1 && Arr[i - 1] < Arr[i])
                count++;
            else
                count = 1;
            if (sequence < count)
                sequence = count;
            i++;
        }
        Console.WriteLine(sequence);
    }
}
