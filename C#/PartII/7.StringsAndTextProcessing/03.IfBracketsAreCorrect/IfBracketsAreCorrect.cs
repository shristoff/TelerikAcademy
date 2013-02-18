/* Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)). */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class IfBracketsAreCorrect
{
    static void Main()
    {
        Console.WriteLine("Please enter math expression with brackets: ");
        string expression = Console.ReadLine();
        string pattern1 = @"[(]+?";
        string pattern2 = @"[)]+?";
        Match match1 = Regex.Match(expression, pattern1);
        Match match2 = Regex.Match(expression, pattern2);
        List<int> indiceOpeningBrackets = new List<int>();
        List<int> indiceClosingBrackets = new List<int>();
        bool bracketsAreCorrect = true;
        while (match1.Success)
        {
            indiceOpeningBrackets.Add(match1.Index); 
            match1 = match1.NextMatch();
        }
        while (match2.Success)
        {
            indiceClosingBrackets.Add(match2.Index); 
            match2 = match2.NextMatch();
        }
        if (indiceOpeningBrackets.Count != indiceClosingBrackets.Count)
            Console.WriteLine("The brackets are not correct!");
        else
        {
            for (int i = 0; i < indiceOpeningBrackets.Count; i++)
			{
                if (indiceOpeningBrackets[i] > indiceClosingBrackets[i])
                {
                    bracketsAreCorrect = false;
                    Console.WriteLine("The brackets are not correct!");
                    break;
                }
			}
            if (bracketsAreCorrect)
                Console.WriteLine("The brackets are correct!");
        }
    }
}