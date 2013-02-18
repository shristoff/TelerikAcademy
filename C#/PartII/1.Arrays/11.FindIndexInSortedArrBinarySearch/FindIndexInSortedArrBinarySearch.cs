/*Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm.*/

using System;

class FindIndexInSortedArrBinarySearch
{
    static void Main()
    {
        int i = 0, start = 0, end = 0, delta = 0, index = 0;
        Console.WriteLine("Enter the length of the array N:");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);        
        int[] Arr = new int[N];
        while (i < N)
        {
            Console.WriteLine("Please enter the {0} number of the array in ascending order", i + 1);
            string Numstr = Console.ReadLine();
            Arr[i] = int.Parse(Numstr);
            i++;
        }
        Console.WriteLine("Enter the element which index you search for:");
        string strSearchedElement = Console.ReadLine();
        int SearchedElement = int.Parse(strSearchedElement);
        end = N - 1;    //краят на интервала в който търсим елемента е равен на последния индекс на масива
        do
        {
            delta = (end - start) / 2;     //делта е половината интервал - ще я добавяме към по-далечния от елемента край на интервала
            if (delta == 0 && N > 1)        //заради целочисленото деление, с което получаваме делта, тя става 0 една итерация преди да сме свили интервала 
                delta = 1;                  //(start = end) затова, когато стане 0 й даваме пак стойност 1, N > 1, защото при масив от 1 елемент index става 1;
            index = start + delta;          //средният индекс е равен на началото на интервала + половината на интервала
            if (SearchedElement < Arr[index]) //ако търсеният елемент е по-малък от средния елемент разглеждаме първата половина на масива
                end = end - delta;              //краят на първата половина на новия интервал е краят на стария интервал минус половината стар интервал
            else
                start = start + delta;         //ако търсеният елемент е във втората половина на интервала към началото на интервала добавяме половината интервал,
        }                                         //с което изместваме началото на новия интервал в средата на стария
        while (start != end);                   //въртим цикъла докато началото и краят на интервала не станат равни, когато станат равни сме намерили индекса на елемента
        if (Arr[start] != SearchedElement)     //ако намереният индекс не съответства на търсения елемент, значи няма такъв елемент там, където би трябвало да се намира
            Console.WriteLine("No such number in the array");  
        else
            Console.WriteLine(start);
    }
}