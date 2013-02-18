/* Starting from the top left corner of the forest, the road always goes down and right first 
and when it reaches the border, it goes down and left. 
The Academy is situated in the bottom left corner, 
and Geeko begins his journey from the top left corner of the forest */

using System;

class ForestRoad
{
    static void Main()
    {
        string Nstr = Console.ReadLine();
        byte N = byte.Parse(Nstr);
        char Geeko = '*';
        for (byte j = 0; j < N; j++)
        {
            string treesLeft = new String('.', j);
            string treesRight = new String('.', N - j - 1);
            Console.WriteLine(treesLeft + Geeko + treesRight);
        }
        for (byte j = 1; j <= N - 1; j++)
        {
            string treesLeft = new String('.', N - j - 1);
            string treesRight = new String('.', j);
            Console.WriteLine(treesLeft + Geeko + treesRight);
        }
    }
}