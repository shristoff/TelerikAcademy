/* Write a program to calculate n! for each n in the range [1..100]. 
 Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.  
ЗАДАЧАТА Е РЕШЕНА ПО ВТОРАТА ЧАСТ НА УПЪТВАНЕТО В УЧЕБНИКА:
 Друг, по-лесен вариант да работите с големи числа като 100!, е чрез библиотеката System.Numerics.dll, 
 която можете да използвате в проектите си като преди това добавите референция към нея. */

using System;
using System.Numerics;

class CalculateNfactForNLessThan100
{
    static BigInteger CalculateFactorial(int num)
    {
        BigInteger fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact = i * fact;
        }
        return fact;
    }

    static void Main()
    {
        Console.WriteLine("Please enter number between 1 and 100: ");
        int num = int.Parse(Console.ReadLine());
        BigInteger fact = CalculateFactorial(num);
        Console.WriteLine("{0}! = {1}", num, fact);                                              
    }
}
