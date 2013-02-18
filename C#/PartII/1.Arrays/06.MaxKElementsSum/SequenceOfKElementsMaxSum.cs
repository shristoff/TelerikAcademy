/*Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 Find in the array those K consecutive elements that have maximal sum.*/

using System;

class SequenceOfKElementsMaxSum

{
    static void Main()
    {
        int i = 0, j = 0, max = 0, sum = 0, start = 0, end = 0;
        Console.WriteLine("Enter the length of the array N:");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        Console.WriteLine("Enter the number of consecutive elements K:");
        string Kstr = Console.ReadLine();
        int K = int.Parse(Kstr);
        int[] Arr = new int[N];
        while (i < N)
        {
            Console.WriteLine("Please enter the {0} number of the array", i + 1);
            string Numstr = Console.ReadLine();
            Arr[i] = int.Parse(Numstr);
            if (i < K)
                sum = sum + Arr[i];
            else
                sum = sum + Arr[i] - Arr[i - K];
            if (max <= sum)
            {
                max = sum;
                start = i - K + 1;
                end = i;
            }
            i++;
        }
        Console.Write("\nK elements are: ");
        for (j = start; j <= end; j++)
        {
            Console.Write("{0}; ", Arr[j]);
        }
        Console.WriteLine("\nTheir sum is: {0}\n", max);
    }
}
