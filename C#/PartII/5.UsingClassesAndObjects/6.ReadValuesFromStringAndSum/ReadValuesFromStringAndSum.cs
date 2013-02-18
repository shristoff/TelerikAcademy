/*You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum. 
Example: string = "43 68 9 23 318"  result = 461 */

using System;

class ReadValuesFromStringAndSum
{
    static string[] SplitStringBySpaces(string stringToSplit)
    {
        string[] words = stringToSplit.Split(' ');
        return words;
    }

    static void Main()
    {
        int sum = 0;
        Console.WriteLine("Please enter numbers divided by spaces:");
        string[] words = SplitStringBySpaces(Console.ReadLine());
        for (int i = 0; i < words.Length; i++)
			{
                sum = sum + int.Parse(words[i]);
			}
        Console.WriteLine("The sum is: {0}", sum);
    }
}