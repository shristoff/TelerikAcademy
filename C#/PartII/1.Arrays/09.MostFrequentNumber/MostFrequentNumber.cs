/*Write a program that finds the most frequent number in an array. Example:	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times) */

using System;

class MostFrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array:");
        string Lengthstr = Console.ReadLine();
        int Length = int.Parse(Lengthstr);
        int i = 0, j, Equals = 0, count = 1, index = 0;
        int[] Arr = new int[Length];
        while (i < Length)
        {
            Console.WriteLine("Please enter the {0} number of the array", i + 1);
            string Numstr = Console.ReadLine();
            Arr[i] = int.Parse(Numstr);
            i++;
        }
        for (i = 0; i < Length; i++)
		{
            for (j = 0; j < Length; j++)
            {
                if (Arr[i] == Arr[j] && i != j)
                    count++;
            }
            if (Equals < count)
            {
                Equals = count;
                index = i;
            }
            count = 0;
        }
        if (Equals > 1)
            Console.WriteLine("Most frequent number ({0}) times is: {1}", Equals, Arr[index]);
        else
            Console.WriteLine("Every number is unique!");
    }
}