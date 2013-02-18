/*Write a program that finds the sequence of maximal sum in given array. Example:{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
Can you do it with only one loop (with single scan through the elements of the array)?.*/

using System;

class SequenceWithMaxSum
{
    static void Main()
    {
        int i = 0, j = 0, max = int.MinValue, sum = 0, start = 0, end = 0;
        Console.WriteLine("Enter the length of the array N:");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        int[] Arr = new int[N];
        while (i < N)
        {
            Console.WriteLine("Please enter the {0} number of the array", i + 1);
            string Numstr = Console.ReadLine();
            Arr[i] = int.Parse(Numstr);
            i++;
        }
        for (i = 0; i < N; i++)
        {
            for (j = 0; j < N; j++)
            {
                if (i + j < N)                 //предотвратява излизане на индекса извън размера на масива
                    sum = sum + Arr[i + j];   //събира последователно елементите (1, 1+2, 1+2+3...; 2, 2+3, 2+3+4...; 3, 3+4, 3+4+5...)
                if (sum > max)                //ако сумата им е по-голяма от предишната сума
                {
                    max = sum;    //запазване на стойността на новата сума
                    start = i;      //запазване на началото на интервала от елементи с максимална сума
                    end = i + j;   //запазване на края на интервала от елементи с максимална сума
                }
            }
            sum = 0;  //нулиране на сумата
        }
        Console.Write("\nMax sum elements are: ");
        for (j = start; j <= end; j++)
        {
            Console.Write("{0}; ", Arr[j]);
        }
        Console.WriteLine("\nTheir sum is: {0}\n", max);
    }
}