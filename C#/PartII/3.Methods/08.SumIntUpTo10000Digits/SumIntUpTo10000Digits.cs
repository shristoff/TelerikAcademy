/* Write a method that adds two positive integer numbers represented as arrays of digits 
 (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 Each of the numbers that will be added could have up to 10 000 digits. */

using System;
using System.Numerics;
using System.Collections.Generic;

public class SumIntUpTo10000Digits
{
    public static List<byte> Sum(byte[] firstArr, byte[] secondArr)
    {
        byte oneInMind = 0;                    //декларираме на променливата за "едно на ум"
        List<byte> sum = new List<byte>();
        for (int i = 0; i < firstArr.Length; i++)     //основната част на алгоритъма
        {
            if (firstArr[i] + secondArr[i] + oneInMind > 9)   //ако сборът на съответните цифри и остатъка
            {                                                //е по-голям от 9, съответната цифра в резултата
                sum.Add((byte)((firstArr[i] + secondArr[i] + oneInMind) % 10)); //е дясната цифра на полученото
                oneInMind = 1;                                      //двуцифрено число и имаме "едно на ум"
            }
            else                                //ако е по-малък от 10
            {                                   //съответната цифра е равна на сбора
                sum.Add((byte)(firstArr[i] + secondArr[i] + oneInMind)); 
                oneInMind = 0;                  //вече нямаме "едно на ум", защото сме го добавили, ако сме имали
            }
        }
        sum.Reverse();     //обръщаме листа
        if (sum[0] == 0)    //ако първата цифра е нула (или с други думи полученият резултат е с една цифра по-голям
            sum.Remove(0);   //от по-дългото число) тогава махаме тази 0
        return sum;
    }
    
    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        string first = Console.ReadLine();                      //четем два стринга за числата 
        Console.WriteLine("Please enter second number: ");
        string second = Console.ReadLine();
        byte[] firstArr = new byte[Math.Max(first.Length, second.Length) + 1];   //масивите са с дължината 
        byte[] secondArr = new byte[Math.Max(first.Length, second.Length) + 1];  //на по-голямото число
        for (int i = first.Length - 1; i >= 0; i--)                              //вкарваме числата в масивите
        {
            firstArr[first.Length - i - 1] = byte.Parse(first[i].ToString());
        }
        for (int i = second.Length - 1; i >= 0; i--)
        {
            secondArr[second.Length - i - 1] = byte.Parse(second[i].ToString());
        }
        BigInteger justCheck = BigInteger.Parse(first) + BigInteger.Parse(second); //за проверка за проверяващия сумираме числата
        Console.WriteLine(justCheck);                                               //печатаме сбора им в BigInteger
        foreach (byte digit in Sum(firstArr, secondArr))                      //печатаме и сбора, който ние сме получили в метода
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }
}
