/*You are given a list of 8 bytes (positive integers in the range [0…255]) n0, n1, …, n7.
These numbers represent a square grid consisting of 8 lines and 8 columns.
Each cell of the grid could either be empty or full. The first line is represented by the bits of n0, the second – 
 by the bits of n1 and so on, and the last line is represented by the bits of n7.
Each bit with value 1 denotes a full cell and each bit with value 0 denotes an empty cell.
The lines are numbered from the first (top) to the last (bottom) with the numbers 0, 1, …, 7.
The columns are numbered from right to left with the indices 0, 1, …, 7.
The figure shows a sample square grid and its representation by a sequence of 8 numbers n0, n1, …, n7:
	7	6	5	4	3	2	1	0	
0					■				n0 = 8
1		■			■				n1 = 72
2					■				n2 = 8
3					■				n3 = 8
4				■					n4 = 16
5				■	■	■			n5 = 28
6	■	■	■	■					n6 = 240
7									n7 = 0
A line is any sequence of full cells staying on the same row or column.
At the figure above we have two lines of 4 cells and two lines of 3 cells and one line of 1 cell.
You need to create a program that finds the longest line in the grid and the number of lines with the longest length.
At the figure we have two largest lines with length of 4 cells. */

using System;

class Lines
{
    static void Main()
    {
        int[,] numbers = new int[14, 14];
        int row, col, count = 0, i = 0;
        int Lines = 0, LinesRows = 0, LinesCols = 0, MaxLengthRows = 0, MaxLengthCols= 0;
        for (row = 0; row < 8; row++)
        {
            string Numstr = Console.ReadLine();
            numbers[row, 8] = byte.Parse(Numstr);
            for (col = 0; col < 8; col++)
            {
                numbers[row, col] = (numbers[row, 8] >> col) & 1;
            }
        }
        for (row = 0; row < 8; row++)
        {
            for (col = 0; col < 8; col++)
            {
                if (numbers[row, col] == 1)
                    count++;
                if (numbers[row, col] == 0 || col == 7)
                {
                    if (numbers[row, 9] < count)
                    {
                        numbers[row, 9] = count;
                    }
                    if (count != 0 && i < 4)
                    {
                        numbers[row, 10 + i] = count;
                        i++;
                    }
                    count = 0;
                }
            }
            if (numbers[row, 9] > MaxLengthRows)
                MaxLengthRows = numbers[row, 9];
            i = 0;
        }
        count = 0;
        i = 0;
        for (col = 0; col < 8; col++)
        {
            for (row = 0; row < 8; row++)
            {
                if (numbers[row, col] == 1)
                    count++;
                if (numbers[row, col] == 0 || row == 7)
                {
                    if (numbers[9, col] < count)
                    {
                        numbers[9, col] = count;
                    }
                    if (count != 0 && i < 4)
                    {
                        numbers[10 + i, col] = count;
                        i++;
                    }
                    count = 0;
                }
            }
            if (numbers[9, col] > MaxLengthCols)
                MaxLengthCols = numbers[9, col];
            i = 0;
        }
        for (row = 0; row < 8; row++)
        {
            for (col = 10; col < 14; col++)
            {
                if (numbers[row, col] == MaxLengthRows)
                    LinesRows++;
            }
        }
        for (col = 0; col < 8; col++)
        {
            for (row = 10; row < 14; row++)
            {
                if (numbers[row, col] == MaxLengthCols)
                    LinesCols++;
            }
        }
        if (MaxLengthRows == MaxLengthCols)
        {
            Lines = LinesRows + LinesCols;
            if (MaxLengthRows == 1)
                Lines = (LinesRows + LinesCols) / 2;
            Console.WriteLine(MaxLengthRows);
            Console.WriteLine(Lines);
        }
        if (MaxLengthRows > MaxLengthCols)
        {
            Console.WriteLine(MaxLengthRows);
            Console.WriteLine(LinesRows);
        }
        if (MaxLengthRows < MaxLengthCols)
        {
            Console.WriteLine(MaxLengthCols);
            Console.WriteLine(LinesCols);
        }
    }
}