/*Write a program that reads two arrays from the console and compares them element by element.*/
 
using System;
 
class ReadAndCompareTwoArrays
{
    static void Main()
    {
        int i = 0;
        Console.WriteLine("Enter the length of the First array:");
        string FLengthstr = Console.ReadLine();
        int FLength = int.Parse(FLengthstr);
        Console.WriteLine("Enter the length of the Second array:");
        string SLengthstr = Console.ReadLine();
        int SLength = int.Parse(SLengthstr);
        if (FLength != SLength)
            Console.WriteLine("The arrays are not equal");
        int[] First = new int[FLength];
        int[] Second = new int[FLength];
        bool Compare = true;
        while (i < FLength)
        {
            Console.WriteLine("Please enter the {0} number of first array", i + 1);
            string FNum = Console.ReadLine();
            First[i] = int.Parse(FNum);
            Console.WriteLine("Please enter the {0} number of second array", i + 1);
            string SNum = Console.ReadLine();
            Second[i] = int.Parse(SNum);
            Compare = (First[i] == Second[i]);
            if (Compare == false)  
                break;
            i++;
        }
        Console.WriteLine("The arrays are equal is {0}", Compare);
    }
}
