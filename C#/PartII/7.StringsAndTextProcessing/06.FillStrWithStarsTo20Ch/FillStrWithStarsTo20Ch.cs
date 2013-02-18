/* Write a program that reads from the console a string of maximum 20 characters. 
 If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
 Print the result string into the console. */

using System;

class FillStrWithStarsTo20Ch
{
    static void Main()
    {
        string input = "";
        do
        {
            Console.Write("Please enter string with no more than 20 characters: ");
            input = Console.ReadLine();
        }
        while (input.Length > 20);
        string stars = new string('*', 20 - input.Length);
        if (input.Length < 20)
            Console.WriteLine(input + stars);
    }
}