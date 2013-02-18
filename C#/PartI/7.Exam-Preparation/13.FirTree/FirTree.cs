/* In the spirit of the event your task is to write a program that prints a fir tree to the console.
The format of the tree is shown in the examples bellow. */

using System;

class FirTree
{
    static void Main()
    {
        string Nstr = Console.ReadLine();
        int N = byte.Parse(Nstr);
        char Star = '*';
        for (int j = N - 2, s = 1; j >= 0; j--, s = s + 2)
        {
            string Left = new String('.', j);
            string Right = new String('.', j);
            string Tree = new String(Star, s);
            Console.WriteLine(Left + Tree + Right);
        }
        string Stem = new String('.', N - 2);
        Console.WriteLine(Stem + Star + Stem);
    }
}