/* * Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size.*/

//НЕ Е ДОВЪРШЕНА!!!
using System;

class StrMaxSeqRowColDi
{
    static void Main()
    {
        Console.Write("Enter the number of columns of the array N: ");
        string nStr = Console.ReadLine();
        int n = int.Parse(nStr);
        Console.Write("Enter the number of rows of the array M: ");
        string mStr = Console.ReadLine();
        int m = int.Parse(mStr);
        int[,] arr2D = new int[m, n];
        int row = 1, col = 1, maxArea = 0, count = 0, equalElement = 0;
        bool[,] equalCells = new bool[3, 3];
        for (row = 0; row < m; row++)
        {
            Console.Write("Please enter the elements of the array by rows:\nrow {0}: ", row);
            for (col = 0; col < n; col++)
            {
                string numStr = Console.ReadLine();
                arr2D[row, col] = int.Parse(numStr);
            }
            Console.WriteLine();
        }
        row = 1; col = 1;
        while (row < m && col < n)
        {
            equalCells[0, 0] = arr2D[row, col] == arr2D[row - 1, col - 1];  //горе-ляво
            equalCells[0, 1] = arr2D[row, col] == arr2D[row - 1, col];      //горе
            equalCells[0, 2] = arr2D[row, col] == arr2D[row - 1, col + 1];  //горе-дясно
            equalCells[1, 0] = arr2D[row, col] == arr2D[row, col - 1];      //ляво
            equalCells[1, 2] = arr2D[row, col] == arr2D[row, col + 1];      //дясно
            equalCells[2, 0] = arr2D[row, col] == arr2D[row + 1, col - 1];  //долу-ляво
            equalCells[2, 1] = arr2D[row, col] == arr2D[row + 1, col];      //долу
            equalCells[2, 2] = arr2D[row, col] == arr2D[row + 1, col + 1];  //долу-дясно
            if (equalCells[0, 0])
            {
                row--;
                col--;
                count++;
            }
            if (equalCells[0, 1])
            {
                row++;
                count++;
            }
            if (equalCells[0, 2])
            {
                row--;
                col++;
                count++;
            }
            if (equalCells[1, 0])
            {
                col--;
                count++;
            }
            if (equalCells[1, 2])
            {
                col++;
                count++;
            }
            if (equalCells[2, 0])
            {
                row++;
                col--;
                count++;
            }
            if (equalCells[2, 1])
            {
                row--;
                count++;
            }
            if (equalCells[2, 2])
            {
                row++;
                col++;
                count++;
            }
            if (count > maxArea)
            {
                maxArea = count;
                equalElement = arr2D[row, col];
            }
            if (!(equalCells[0, 0] || equalCells[0, 1] || equalCells[0, 2] || equalCells[1, 0] ||
                  equalCells[1, 2] || equalCells[2, 0] || equalCells[2, 1] || equalCells[2, 2]))
            {
                count = 0;
                if (col < n - 1)
                {
                    col++;
                }
                else
                {
                    row++;
                    col = 0;
                }
            }
        }
        Console.WriteLine("The biggest area consists of {0} times number {1}", maxArea, equalElement);
    }
}