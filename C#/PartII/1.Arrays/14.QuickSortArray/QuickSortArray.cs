/* Write a program that sorts an array of strings using the quick sort algorithm.*/

using System;

class QuickSortArray
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array N:");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        int[] Arr = new int[N];
        int i = 0, j = 0, index, temp;
        while (i < N)
        {
            Console.WriteLine("Please enter the {0} number of the array", i + 1);
            string Numstr = Console.ReadLine();
            Arr[i] = int.Parse(Numstr);
            i++;
        }
        i = 0;
        do
        {
            index = j;            
            while (i < N)
            {
                if (Arr[i] < Arr[index] && i > index) //ако pivot елемента е по-голям от текущия, а индексът му е по-малък от текущия
                {                                      //разменяме елементите
                    temp = Arr[i];
                    Arr[i] = Arr[index];
                    Arr[index] = temp;
                    index = i;                          //индекс става равен на текущия индекс, защото са разменени елементите вече, 
                }                                       //а проверката трябва да продължи със същия елемент
                if (Arr[i] > Arr[index] && i < index)   //ако pivot елемента е по-малък от текущия, а индексът му е по-голям от текущия
                {                                        //разменяме елементите
                    temp = Arr[i];
                    Arr[i] = Arr[index];
                    Arr[index] = temp;
                    index = i;                  //индекс става равен на текущия индекс, защото са разменени елементите вече, 
                }                                    //а проверката трябва да продължи със същия елемент
                i++;
            }
            i = 0;
            j++;
        }
        while (j < N);
        foreach (var item in Arr)
        {
            Console.Write("{0} ", item);
        }
    }
}
