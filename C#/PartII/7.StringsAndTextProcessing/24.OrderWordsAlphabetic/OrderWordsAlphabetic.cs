/* Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order. */

using System;

class OrderWordsAlphabetic
{
    static void Main()
    {
        Console.WriteLine("Please enter words, separated by spaces:");
        string[] words = (Console.ReadLine()).Split(' ');
        Array.Sort(words);
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}