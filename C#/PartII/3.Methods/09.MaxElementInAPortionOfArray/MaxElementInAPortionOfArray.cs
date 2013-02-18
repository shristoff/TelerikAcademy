/* Write a method that return the maximal element in a portion of array of integers starting at given index. 
 Using it write another method that sorts an array in ascending / descending order. */

using System;

class MaxElementInAPortionOfArray
{
    static void ReplaceElements(int[]arr, int first, int second)
    {
        if (arr[first] == arr[second])
            return;
        arr[first] = arr[second] + arr[first];         
        arr[second] = arr[first] - arr[second];       //second = (second + first) - second = first
        arr[first] = arr[first] - arr[second];        //first = (second + first) - first = second 
    }
    
    static int FindBiggestElement(int[] arr, int k)
    {
        int maxNum = 0;
        bool biggest = false;
        for (int i = k; i < arr.Length; i++)
        {
            for (int j = k; j < arr.Length; j++)   
            {                                  
                biggest = arr[i] >= arr[j];  //булева промелнива biggest, която е със стойност false до намирането на 
                if (!biggest)               //най-големия елемент, ако намерим по-голям от проверявания елемент (biggest = false) 
                    break;               //излизаме от вътрешния цикъл, за да не се върти без нужда
            }
            if (biggest)                //ако не сме намерили по-голям от проверявание елемент  (biggest = true)
                maxNum = arr[i];         //записваме стойността в maxNum
        }
        return maxNum;
    }

    static int[] SelectionSort(int[] arr) //разширение на метода за намирането на най-голямо число до метод за 
    {
        int count = 0;
        bool biggest = false;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0 + count; j < arr.Length; j++)   //count ще брои колко най-големи елемента са намерени до момента
            {                                 //добавяме count към j, за да проверяваме само останалите
                biggest = arr[i] >= arr[j];    //булева променлива biggest, която е false намирането на най-голям елемент
                if (!biggest)           //ако намерим по-малък от проверявания елемент (biggest = false)
                    break;               //излизаме от вътрешния цикъл, за да не върти без нужда
            }
            if (biggest)              //ако не сме намерили по-голям елемент от проверявания (biggest = true)
            {
                ReplaceElements(arr, count, i);    //слагаме намерения пореден голям елемент след предишните големи
                count++;            //увеличаваме брояча на намерените най-големи елементи
                i = count - 1;     //нагласяме основния брояч така че да не проверява вече сортираните елементи
            }
        }
        return arr;
    }

    static void Main()
    {
        Console.WriteLine("Enter the length of the array N:");
        string nStr = Console.ReadLine();
        int n = int.Parse(nStr);
        Console.WriteLine("Enter the start index K:");
        string kStr = Console.ReadLine();
        int k = int.Parse(kStr), i = 0;
        int[] arr = new int[n];
        Console.WriteLine("Please enter the numbers of the array:");
        while (i < n)
        {
            string Numstr = Console.ReadLine();
            arr[i] = int.Parse(Numstr);
            i++;
        }
        Console.WriteLine("The biggest element in the choosen portion (from k to n) is: {0} \n", FindBiggestElement(arr, k));
        SelectionSort(arr);
        foreach (int num in arr)
        {
            Console.Write("{0} ", num);
        }
    }
}
