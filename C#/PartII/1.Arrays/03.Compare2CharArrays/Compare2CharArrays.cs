/*Write a program that compares two char arrays lexicographically (letter by letter).*/

using System;

class Compare2CharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the First array:");
        string FLengthstr = Console.ReadLine();
        int FLength = int.Parse(FLengthstr);
        Console.WriteLine("Enter the length of the Second array:");
        string SLengthstr = Console.ReadLine();
        int SLength = int.Parse(SLengthstr);
        char[] First = new char[FLength];        
        char[] Second = new char[SLength];
        int i = 0;
        while (i < FLength)
        {
            Console.WriteLine("Please enter the {0} char of first array", i + 1);
            string Fchar = Console.ReadLine();
            First[i] = char.Parse(Fchar);
            i++;
        }
        i = 0;
        while (i < SLength)
        {
            Console.WriteLine("Please enter the {0} char of second array", i + 1);
            string Schar = Console.ReadLine();
            Second[i] = char.Parse(Schar);
            i++;
        }
        i = 0;
        while (First[i] == Second[i] && ((i + 1) < Math.Min(FLength, SLength)))
        {
            if (First[i + 1] < Second[i + 1])
            {
                Console.WriteLine("The First array is lexicographically before the Second");
                break;
            }
            if (Second[i + 1] < First[i + 1])
            {
                Console.WriteLine("The Second array is lexicographically before the First");
                break;
            }
            if (First[i + 1] == Second[i + 1] && (i + 2) == Math.Min(FLength, SLength))
            {
                if (FLength < SLength)
                    Console.WriteLine("The First array is lexicographically before the Second");
                if (SLength < FLength)
                    Console.WriteLine("The Second array is lexicographically before the First");
                if (FLength == SLength)
                    Console.WriteLine("The arrays are lexicographically equal");
            }
            i++;
        }
        if (First[0] < Second[0])
            Console.WriteLine("The First array is lexicographically before the Second");
        if (Second[0] < First[0])
            Console.WriteLine("The Second array is lexicographically before the First");
    }
}