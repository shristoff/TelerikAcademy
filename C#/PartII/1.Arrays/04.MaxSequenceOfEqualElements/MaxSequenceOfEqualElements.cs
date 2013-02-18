/*Write a program that finds the maximal sequence of equal elements in an array. Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.*/

using System;

class MaxSequenceOfEqualElements
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
            if (i >= 1 && Arr[i - 1] == Arr[i])
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
