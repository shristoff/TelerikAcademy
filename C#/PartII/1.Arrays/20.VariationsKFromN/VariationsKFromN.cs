/* Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
 Example:	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3} */

using System;

class VariationsKFromN
{
    static void Main()
    {
        Console.Write("Enter number of elements in the array N: ");
        string nStr = Console.ReadLine();
        int n = int.Parse(nStr);
        Console.Write("Enter number of elements for variations K: ");
        string kStr = Console.ReadLine();
        int k = int.Parse(kStr);
        Console.WriteLine("The variations of K from N are: ");
        int i = 0, j = 1;
        int[] variations = new int[k];
        while (i < k)
        {
            variations[i] = 1;
            i++;
        }
        while (k >= j)
        {
            foreach (var num in variations)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            j = 1;
            variations[k - j] = variations[k - j] + 1;
            while (variations[k - j] > n)
            {
                variations[k - j] = 1;
                j++;
                if (k < j)
                    return;
                variations[k - j] = variations[k - j] + 1;
            }
        }
    }
}