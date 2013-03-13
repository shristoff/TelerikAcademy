/*6.Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
 Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintNumbersFromArr
{
    class PrintNumbersFromArrDivBy3And7
    {
        //prints numbers that are divisible by 7 and 3
        static void PrintNumbersFromArrDivBy21(int[] numbers)
        {
            var divBy21 = numbers.Where(number => number % 21 == 0);
            PrintSelected(divBy21);
        }
        //Rewrite the same with LINQ.
        static void PrintNumbersFromArrDivBy21LINQ(int[] numbers)
        {
            var divBy21 =
                from number in numbers
                where number % 21 == 0
                select number;
            PrintSelected(divBy21);
        }
        //Print numbers
        static void PrintSelected(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        //main method
        static void Main()
        {
            int[] ints = { 5, 16, 12, 21, 45, 42, 67, 63 };
            PrintNumbersFromArrDivBy21(ints);
            Console.WriteLine(new string('_', 30));
            PrintNumbersFromArrDivBy21LINQ(ints);
        }
    }
}
