/*You are given a list of 8 bytes (positive integers in the range [0…255]) n0, n1, …, n7. These numbers represent a square grid consisting of 8 lines and 8 columns. Each cell of the grid could either be empty or full. The first line is represented by the bits of n0, the second – by the bits of n1 and so on, and the last line is represented by the bits of n7. Each bit with value 1 denotes a full cell and each bit with value 0 denotes an empty cell. The lines are numbered from the first (top) to the last (bottom) with the numbers 0, 1, …, 7. The columns are numbered from right to left with the indices 0, 1, …, 7. The figure shows a sample square grid and its representation by a sequence of 8 numbers n0, n1, …, n7:
	7	6	5	4	3	2	1	0				7	6	5	4	3	2	1	0	
0									n0 = 0		0									n0 = 0
1		■							n1 = 64		1									n1 = 0
2					■				n2 = 8		2									n2 = 0
3					■				n3 = 8		3									n3 = 0
4									n4 = 0		4									n4 = 0
5					■	■			n5 = 12		5					■				n5 = 8
6	■	■	■						n6 = 224	6		■			■				n6 = 72
7									n7 = 0		7	■	■	■		■	■			n7 = 236
Suppose the full cells hold squares which can "fall down" by the influence of the gravity. Each full cell in certain row and column falls down to the lowest row possible but stays in the same column and up from any other full cells on the same column that ware initially down from it. At the figure the "fall down" process is illustrated.
Write a program to calculate how the grid will look like after the "fall down" process is applied.*/

using System;

class FallDown
{
    static void Main()
    {
        int[,] numbers = new int[9,9];
        int row;
        int col;
        for (row = 0; row < 8; row++)
        {
            string Numstr = Console.ReadLine();
            numbers[row,8] = byte.Parse(Numstr);
            for (col = 0; col < 8 ; col++)
            {
                numbers[row,col] = (numbers[row,8] >> col) & 1;
            }
        }
        for (row = 0; row < 8; row++)
        {
            for (col = 0; col < 8; col++)
            { 
                if (numbers[row,col] == 1)
                {
                    numbers[8,col]++;
                    numbers[row, col] = 0;
                }
                
            }
        }
        for (col = 0; col < 8; col++)
        {
            row = 7;
            while (numbers[8, col] > 0)
            {
                numbers[row, col] = 1;
                numbers[8, col]--;
                row--;
            }
        }
        for (row = 0; row < 8; row++)
        {
            numbers[row, 8] = 0;
            for (col = 0; col < 8; col++)
            {
                numbers[row, 8] = numbers[row, 8] + numbers[row, col] * (int)Math.Pow(2, col);           
            }
            Console.WriteLine(numbers[row, 8]);
        }
    }
}