/* *We are given an array of integers and a number S. Write a program to find if there exists a 
 subset of the elements of the array that has a sum S. Example:	arr = {2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6).*/

using System;
using System.Collections.Generic;

class SubsetSums
{
    static void Main()
    {
        Console.WriteLine("Enter sum S: ");
        string Sstr = Console.ReadLine();
        long S = long.Parse(Sstr);
        Console.WriteLine("Enter number of elements in the array N: ");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        long[] numbers = new long[N];
        List<long> subset = new List<long>();
        long sum = 0, SsumSubsets = 0, combinations = 1;
        byte i = 0, j = 0;
        Console.WriteLine("Enter array numbers: ");
        while (i < N)
        {
            string Numstr = Console.ReadLine();
            long Num = long.Parse(Numstr);
            numbers[i] = Num;
            i++;
        }
        for (i = 1; i <= numbers.Length; i++)
        {
            combinations = 2 * combinations;        //повдигам на 2 на степен броя на числата, за да получа броя на комбинациите
        }
        for (int comb = 1; comb < combinations; comb++)  //за всяка комбинация от числа 
        {
            for (j = 0; j < numbers.Length; j++)      //обикалям всички елементи на масива
            {
                sum = sum + ((comb >> j) & 1) * numbers[j];  //побитово генериране на всички комбинации (с умножение с 0 или 1 на всяко от числата)
                if (((comb >> j) & 1) != 0 )  //ако числото влиза в комбинацията
                    subset.Add(numbers[j]);                                                 //го прибавям към списък 
            }
            if (sum == S)  //ако сумата на поредната комбинация от числа е равна на S,  
            {
                j = 0;
                SsumSubsets++;                                                          //броя коя е сумата подред
                Console.Write("\nSubset number {0} members are: ", SsumSubsets); //печатам за съответния номер сума всички числа, които я образуват
                foreach (long item in subset)
                {
                    Console.Write("{0} ", subset[j]);
                    j++;
                }
            }
            sum = 0;                              //нулирам сумата
            subset.RemoveRange(0, subset.Count);  //изчиствам всички елементи в списъка, за да е готов за добавяне на следващите числа от начало
        }
        Console.WriteLine("\nTotal number of subsets with sum S is: {0}", SsumSubsets);
    }
}