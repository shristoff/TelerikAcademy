/* Write a program that sorts an array of integers using the merge sort algorithm. */

using System;
using System.Collections.Generic;

class MergeSortArray
{
    static List<int> Merge(List<int> left, List<int> right)  //методът използва два списъка (left, right), които слива в един сортиран списък
    {
        List<int> result = new List<int>();    //декларираме списъка, в който ще получим резултата от сливането и сортирането
        while (left.Count > 0 || right.Count > 0)   //докато има елементи в поне един от двата списъка
        {
            if (left.Count > 0 && right.Count > 0)   //ако има елементи и в двата списъка
            {
                if (left[0] <= right[0])    //ако първият елемент от левия списък е по-малък или равен от/на първия елемент от десния списък
                {
                    result.Add(left[0]);  //постави по-малкия елемент от двата на първо място в сортирания списък
                    left.Remove(left[0]);  //премахни по-малкия елемент от списъка, в който е бил досега
                }
                else
                {
                    result.Add(right[0]);  //постави по-малкия елемент от двата на първо място в сортирания списък
                    right.Remove(right[0]);   //премахни по-малкия елемент от списъка, в който е бил досега
                }
            }
            else if (left.Count > 0)    //ако първият списък има елементи
            {
                result.Add(left[0]);  //постави най-левият елемент от този списък на първо място в сортирания списък
                left.Remove(left[0]);    //премахни елемента от списъка, в който е бил досега
            }
            else if (right.Count > 0)  //ако вторият списък има елементи
            {
                result.Add(right[0]);    //постави най-левият елемент от този списък на първо място в сортирания списък
                right.Remove(right[0]);   //премахни елемента от списъка, в който е бил досега
            }
        }
        return result;   //върни като резултат сортирания слят списък
    }
    
    static List<int> Merge_sort(List<int> numbers)   //метод, който разделя един списък на два равни по брой елементи преди и след средата на големия списък
    {
        if (numbers.Count <= 1)   //ако големият списък от елементи има 0 или 1 елемента
            return numbers;       //върни като резултат същия списък, защото няма как да се раздели на два списъка
        List<int> left = new List<int>();   //декларираме левия списък (който ще съдържа елементите вляво от средата на големия)
        List<int> right = new List<int>();  //декларираме десния списък (който ще съдържа елементите вдясно от средата на големия)
        int middle = numbers.Count / 2;     //декларираме променлива за средата на големия списък (равна е на броя елементи делен на две)
        for (int i = 0; i < numbers.Count; i++)  //за всеки елемент (докато не свършат елементите)
		{
			if (i < middle)      //ако индексът на елемента е по-малък от средния индекс (елементът е вляво от средата)
                left.Add(numbers[i]);   //прибави към левия списък този елемент
            else
                right.Add(numbers[i]);   //ако индексът е по-голям от средния индекс (елементът е вдясно от средата) го прибави към десния списък
        }
        left = Merge_sort(left);    // рекурсивно се вика метода, за да се продължи разделянето на левия и десния списък пак на два списъка (ще станат 4)
        right = Merge_sort(right); // докато размерът на списъците не стане 1
        return Merge(left, right);  // с помощта на предишния метод списъците се сливат и сортират
    }                               // и връщат сортирания слят списък

    static void Main()
    {
        Console.WriteLine("Enter the length of the array N:");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        List<int> numbers = new List<int>();
        List<int> Sorted = new List<int>();
        int i = 0;
        while (i < N)
        {
            Console.WriteLine("Please enter the {0} number of the array", i + 1);
            string Numstr = Console.ReadLine();
            numbers.Add(int.Parse(Numstr));
            i++;
        }
        Merge_sort(numbers);                            //подаваме списъкът, който искаме да се сортира на метода за сортиране, който от своя страна
        foreach (var item in Merge_sort(numbers))   //съдържа метода за разделяне на списъци и сортирането им чрез сливане
        {
            Console.Write("{0} ", item);
        }
    }
}