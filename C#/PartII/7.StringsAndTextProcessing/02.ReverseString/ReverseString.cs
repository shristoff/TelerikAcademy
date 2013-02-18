/* Write a program that reads a string, reverses it and prints the result at the console.
Example: "sample"  "elpmas". */

using System;

class ReverseStringClass
{
    static string ReverseString(string inputStr) 
    {
        char[] strToCharArr = inputStr.ToCharArray();
        Array.Reverse(strToCharArr);
        string reversed = new string(strToCharArr);
        return reversed;
    }
    
    static void Main()
    {
        Console.WriteLine("Please enter some string: ");
        string inputStr = Console.ReadLine();
        Console.WriteLine(ReverseString(inputStr));
    }
}
