/* You should print the hourglass on the console. Each row can contain only the following characters: “.” (dot) and “*” (asterisk).
 As shown in the example: the middle row must contain only one ‘*’ and all other symbols must be “.”. 
 Every next row (up or down from the middle one) must contain the same number of ‘*’ as the previous one plus two. 
 You should only use “.” to fill-in the rows, where necessary.*/

using System;

class SandGlass
{
    static void Main()
    {
        string Nstr = Console.ReadLine();
        int N = byte.Parse(Nstr);
        char Star = '*';
        for (int j = 0, s = N; s >= 1; j++, s = s - 2)
        {
            string Left = new String('.', j);
            string Right = new String('.', j);
            string SandGlass = new String(Star, s);
            Console.WriteLine(Left + SandGlass + Right);
        }
        for (int s = 3, j = N / 2 - 1; s <= N; j--, s = s + 2)
        {
            string Left = new String('.', j);
            string Right = new String('.', j);
            string SandGlass = new String(Star, s);
            Console.WriteLine(Left + SandGlass + Right);
        }
    }
}