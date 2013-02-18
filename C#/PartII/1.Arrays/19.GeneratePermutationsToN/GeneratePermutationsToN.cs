/* * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1} */

using System;

class PermutationsToN
{
    static void Main()
    {
        Console.Write("Enter number of elements in the array N: ");
        string nStr = Console.ReadLine();
        int n = int.Parse(nStr);
        Console.WriteLine("The permutations to N are: ");
        int i = 0, j = 1;
        int[] permutations = new int[n]; //инициализиране на масив с размер N
        while (i < n)
        {
            permutations[i] = 1;  //всеки елемент на масива е равен на 1
            i++;
        }
        while (n >= j)  //докато текущата стойност на индекса е не по-голяма от N
        {
            foreach (var num in permutations)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            j = 1;  
            permutations[n - j] = permutations[n - j] + 1;  //последният елемент увеличаваме с 1
            while (permutations[n - j] > n)    //докато елементите от последния напред са по-големи от N
            {
                permutations[n - j] = 1;  //ги правим равни на 1
                j++;                       //намаляваме индекса (n - j) - местим се на по-преден елемент
                if (n < j)                 //ако сме стигнали до първия елемент
                    return;                      //прекратяваме програмата     
                permutations[n - j] = permutations[n - j] + 1;  //увеличаваме текущия елемент с 1
            }
        }
    }
}