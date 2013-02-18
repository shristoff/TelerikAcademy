/*You are given a list of 8 bytes (positive integers in the range [0…255]) n0, n1, …, n7. 
These numbers represent a square grid consisting of 8 lines and 8 columns. 
Each cell of the grid could either be empty or full. The first line is represented by the bits of n0, the second – by the bits of n1 and so on, 
and the last line is represented by the bits of n7. Each bit with value 1 denotes a full cell and each bit with value 0 denotes an empty cell.
The lines are numbered from the first (top) to the last (bottom) with the numbers 0, 1, …, 7. The columns are numbered from right to left with 
the indices 0, 1, …, 7. The figure shows a square grid and its representation by a sequence of 8 numbers n0, n1, …, n7:
	7	6	5	4	3	2	1	0	
0									n0 = 0
1		■							n1 = 64
2									n2 = 0
3					■				n3 = 8
4									n4 = 0
5					■	■			n5 = 12
6	■	■	■						n6 = 224
7									n7 = 0
We are allowed to put a vertical pillar over any of the columns in the grid. Pillars split the grid into two sides (left and right) 
and the column holding the pillar is ignored. Write a program that finds the leftmost column where the pillar can be put so 
that the full cells on the left side and on the right side are equal number. For example, in the figure if we put the pillar at column 5,
it will split the grid into two sides and both sides will have exactly 3 full cells.*/

using System;

class Pillars
{
    static void Main()
    {
        int[,] numbers = new int[9, 9];
        int row, col, count = 0;
        int Left = 0, Right = 0, Line;
        for (row = 0; row < 8; row++)
        {
            string Numstr = Console.ReadLine();
            numbers[row, 8] = byte.Parse(Numstr);
            for (col = 0; col < 8; col++)
            {
                numbers[row, col] = (numbers[row, 8] >> col) & 1;
                if (numbers[row, col] == 1)
                    numbers[8, col]++;
            }
        }
        for (Line = 7; Line >= 0; Line--)
        {
            Left = 0;
            Right = 0;
            for (col = 0; col < 8; col++)
            {
                if (col < Line)
                    Left = Left + numbers[8, col];
                if (col > Line)
                    Right = Right + numbers[8, col];
            }
            if (Left == Right)
            {
                Console.WriteLine(Line);
                Console.WriteLine(Left);
                count++;
                break;
            }
        }
        if (count == 0)
            Console.WriteLine("No");
    }
}