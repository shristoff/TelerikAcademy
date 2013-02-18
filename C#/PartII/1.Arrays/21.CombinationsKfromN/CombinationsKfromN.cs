/* Write a program that reads two numbers N and K and generates all the combinations of K distinct elements 
from the set [1..N]. Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5} */

using System;

class CombinationsKfromN
{
    static void Main()
    {
        Console.Write("Enter number of elements in the array N: ");
        string nStr = Console.ReadLine();
        int n = int.Parse(nStr);
        Console.Write("Enter number of elements for combinations K: ");
        string kStr = Console.ReadLine();
        int k = int.Parse(kStr);
        Console.WriteLine("The combinations of K from N are: ");
        int i = 0, j = 1;
        int[] variations = new int[k];  //инициализиране на масив с размер K
        while (i < k)
        {
            variations[i] = i + 1;    //въвеждане на масива с поредни числа от 1 до N
            i++;
        }
        while (k >= j)     //докато текущата стойност на индекса е не по-голяма от K
        {
            if (!CheckForEqualNumbers(k, variations))  //ако няма повтарящи се числа в масива
            {
                foreach (var num in variations)   //печатаме масива
                {
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
            j = 1;            //слагаме стойност на индекса 1
            variations[k - j] = variations[k - j] + 1;   //последният елемент на масива увеличаваме с 1
            while (variations[k - j] > n)    //докато елементите отзад напред в масива са по-големи от N
            {
                if (k >= j + 1)           //ако елементът с индекс K - j - 1 е в рамките на масива (К - j - 1 >=0)
                    variations[k - j] = variations[k - j - 1] + 1; //текущият елемент е равен на предишния + 1, а 
                j++;    //намаляваме индекса (k - j)            //не просто на 1, както при вариациите и пермутациите
                if (k < j)  //ако сме стигнали до първия елемент //за да избегнем получаването на разбъркани, но еднакви
                    return;       //прекратяваме програмата                                                //комбинации
                variations[k - j] = variations[k - j] + 1; //ако не увеличаваме текущия елемент с 1
            }
            
        }
    }

    private static bool CheckForEqualNumbers(int k, int[] variations)
    {
        for (int x = 0; x < k; x++)
        {
            for (int y = x + 1; y < k; y++)
            {
                if (variations[x] == variations[y])
                    return true;
            }
        }
        return false;
    }
}
