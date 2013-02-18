/* *Write a program that reads an array of integers and removes from it a minimal number 
of elements in such way that the remaining array is sorted in increasing order. 
Print the remaining sorted array. Example:{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5} */

using System;
using System.Collections.Generic;

class RemoveMinNumElemToSortArray
{
    static void Main()
    {
        Console.Write("Enter number of elements in the array N: ");
        string nStr = Console.ReadLine();
        int n = int.Parse(nStr);
        int[] numbers = new int[n];
        List<int> sorted = new List<int>();
        int[][] allsortedSaved = new int[50][];
        int maxSorted = 0, row = 0, col = 0, m = 0, i = 1, j = 0, combinations = 1, numberOfSorted = 0;
        Console.WriteLine("Enter array numbers: ");
        while (m < n)
        {
            string numStr = Console.ReadLine();
            int num = int.Parse(numStr);
            numbers[m] = num;
            m++;
        }
        for (m = 1; m <= numbers.Length; m++)
        {
            combinations = 2 * combinations;        //повдигам на 2 на степен броя на числата, за да получа броя на комбинациите
        }
        for (int comb = 1; comb <= combinations; comb++)  //за всяка комбинация от числа (докато комбинациите са по-малко от общия брой)
        {
            for (j = 0; j < numbers.Length; j++)      //обикалям всички елементи на масива
            {
                if (((comb >> j) & 1) == 1)  //ако числото влиза в комбинацията
                {
                    sorted.Add(numbers[j]);       //го добавям като първи в списъка, който трябва да е сортиран в последствие
                    for (i = 1; i + j < numbers.Length; i++)  //за всяко от следващите числа в масива (добавям към индекса j последователно 1, 2, 3..,i)
                    {
                        if (((comb >> (j + i)) & 1) == 1 && sorted[sorted.Count - 1] <= numbers[j + i]) //ако следващото число е в комбинацията и 
                        {                                                                               //не е по-малко от първото
                            sorted.Add(numbers[j + i]);    //го добавям към търсения сортиран списък
                        }
                        if (sorted.Count == maxSorted && !CompareArrayToList(allsortedSaved, sorted))  //ако новополученият сортиран списък е с дължина равна на 
                        {                                                                              //най-голямата и все още нямаме същия списък запомнен 
                            allsortedSaved[numberOfSorted] = sorted.ToArray();                     //добавяме в jagged масив новия списък
                            numberOfSorted++;                                                       //увеличаваме брояча на уникалните списъци с максимална 
                        }                                                                           //дължина до сега
                        if (sorted.Count > maxSorted)  //ако новият списък има по-голяма дължина от досегашната най-голяма дължина
                        {
                            maxSorted = sorted.Count;    //записваме новата дължина
                            numberOfSorted = 1;             //нулираме брояча на най-дългите списъци
                            Array.Clear(allsortedSaved, 0, 50);   //изчистваме jagged масива (не са ни нужни досегашните по-къси списъци)
                            allsortedSaved[0] = sorted.ToArray();   //записваме на първи ред в jagged масива новия списък (преобразуваме го от list в array)
                        }
                    }
                    sorted.RemoveRange(0, sorted.Count);   //изчистваме текущия списък, за да го подготвим за следващата комбинация
                }
            }
        }
        Console.Write("Sorted subsets with max length are: {0}\nThey are:\n", numberOfSorted);  //печатаме общата бройка сортирани списъци с максимална дължина
        for (row = 0; row < numberOfSorted; row++)
        {
            for (col = 0; col < maxSorted; col++)
            {
                Console.Write(" {0}", allsortedSaved[row][col]);   //печатаме всеки един от списъците
            }
            Console.WriteLine();
        }
    }

    static bool CompareArrayToList(int[][] arr, List<int> list)  //метод за сравняване на текущия списък с всички списъци записани в jagged масива до момента
    {
        bool equal = true;                
        for (int row = 0; row < 50; row++)       //за всеки ред в jagged масива
	    {
            equal = true;                   //по подразбиране приемаме, че вече има такъв списък
            if (arr[row] != null && arr[row].Length > 0)        //ако има масив на съответния ред на jagged масива
            {
                for (int col = 0; col < arr[row].Length; col++)   //проверяваме всеки един елемент по отделно
                {
                    if (arr[row][col] != list[col])
                    {
                        equal = false;   //ако поне два елемента са различни прекратяваме проверката на този ред
                        break;
                    }
                }
            }
            else                       //ако няма масив на съответния ред на jagged масива излизаме от метода, 
                return false;       //защото сме проверили всички непразни редове
            if (equal)              //ако сме намерили същия масив (equal никога не е станала false)
                return true;        //връщаме резултата, че има вече такъв масив, за да не го записваме 
        }
        return equal;
    }
}