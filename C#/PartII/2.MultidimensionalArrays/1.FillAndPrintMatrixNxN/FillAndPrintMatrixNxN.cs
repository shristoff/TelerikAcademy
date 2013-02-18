/* Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4) */

using System;

class FillAndPrintMatrixNxN
{
    static void Print(int[,] arr2D)
    {
        int row, col;
        for (row = 0; row < arr2D.GetLength(0); row++)
        {
            for (col = 0; col < arr2D.GetLength(1); col++)
            {
                if (arr2D[row, col] >= 100)
                {
                    Console.Write((arr2D[row, col]) + " ");
                }
                else if (arr2D[row, col] < 10)
                {
                    Console.Write((arr2D[row, col]) + "   ");
                }
                else
                {
                    Console.Write((arr2D[row, col]) + "  ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Please enter positive integer N < 20: ");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr), row = 0, col = 0, num = 1, startRow, startCol, endRow, endCol;
        int[,] arr2D = new int[N, N];
        for (row = 0; row < N; row++)
        {
            for (col = 0; col < N; col++)
            {
                arr2D[col, row] = num++;
            }
        }
        Print(arr2D);
        num = 1;
        for (col = 0; col < N; col++)
        {
            if (col % 2 != 0)
            {
                for (row = N - 1; row >= 0; row--)
                {
                    arr2D[row, col] = num++;
                }
            }
            else
            {
                for (row = 0; row < N; row++)
                {
                    arr2D[row, col] = num++;
                }
            }
        }
        Print(arr2D);
        num = 1;
        startRow = N - 1;
        startCol = 0;
        row = N - 1;
        col = 0;
        while (num <= N * N)
        {
            if (row == N - 1 && col != N - 1)
            {
                arr2D[row, col] = num++; 
                col = 0;
                startRow--;
                row = startRow;
            }
            if (col == N - 1 && row != N - 1)
            {
                arr2D[row, col] = num++; 
                row = 0;
                startCol++;
                col = startCol;
            }
            arr2D[row, col] = num++;
            row++;
            col++;
            if (col == N - 1 && row == N - 1)
            {
                arr2D[row, col] = num++;
                startCol++;
                row = 0;
                col = 1;
            }
        }
        Print(arr2D);
        num = 1;
        startRow = 0;
        endRow = N - 1;
        startCol = 0;
        endCol = N - 1;
        row = 0;
        col = 0;
        while (num <= N * N)
        {
            for (row = startRow; row <= endRow; row++)
            {
                arr2D[row, startCol] = num++;
            }
            for (col = startCol + 1; col <= endCol; col++)
            {
                arr2D[endRow, col] = num++;
            }
            for (row = endRow - 1; row >= startRow; row--)
            {
                arr2D[row, endCol] = num++;
            }
            for (col = endCol - 1; col >= startCol + 1; col--)
            {
                arr2D[startRow, col] = num++;
            }
            startRow++;
            endRow--;
            startCol++;
            endCol--;
        }
        Print(arr2D);
    }
}
