/* Write a program that reads a text file containing a square matrix of numbers and
finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
The first line in the input file contains the size of matrix N. 
Each of the next N lines contain N numbers separated by space. 
The output should be a single number in a separate text file. */

using System;
using System.IO;

class ReadMatrixFromFilePrintMaxSumSq
{
    static void Main()
    {
        StreamReader readMatrix = new StreamReader("../../Matrix.txt");
        StreamWriter writeSum = new StreamWriter("../../Output.txt");
        int size = int.Parse(readMatrix.ReadLine());
        int row, col;
        int[,] matrix = new int[size, size];
        string[] stringRow = new string[size];
        using (readMatrix)
        {
            for (row = 0; row < size; row++)
            {
                stringRow = readMatrix.ReadLine().Split(' ');
                for (col = 0; col < size; col++)
                {
                    matrix[row, col] = int.Parse(stringRow[col]);
                }
            }
        }
        using (writeSum)
        {
            writeSum.WriteLine(Find2x2MaxSum(matrix));
        }
    }

    static int Find2x2MaxSum(int[,] arr2D)
    {
        int[,] arrMaxSum = new int[2, 2];
        int row = 0, col = 0, sum = 0, maxSum = Int32.MinValue, count = 1;
        for (row = 1; row + 1 < arr2D.GetLength(0); row++)
        {
            for (col = 1; col < arr2D.GetLength(1); col++)
            {
                sum = arr2D[row - 1, col - 1] + arr2D[row - 1, col] + arr2D[row, col - 1] + arr2D[row, col];
                if (sum == maxSum)
                    count++;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    arrMaxSum[0, 0] = arr2D[row - 1, col - 1];
                    arrMaxSum[0, 1] = arr2D[row - 1, col];
                    arrMaxSum[1, 0] = arr2D[row, col - 1];
                    arrMaxSum[1, 1] = arr2D[row, col];
                    count = 1;
                }
             }
        }
        Console.WriteLine("The array in the file is:\n"); 
        Print(arr2D);
        Console.WriteLine("The 2x2 square with max sum is:\n");
        Print(arrMaxSum);
        Console.WriteLine("The sum of the square is: {0}\nThere is/are {1} 2x2 square(s) with the same sum\n", maxSum, count);
        return maxSum;
    }

    static void Print(int[,] arr2D)
    {
        int row, col;
        for (row = 0; row < arr2D.GetLength(0); row++)
        {
            for (col = 0; col < arr2D.GetLength(1); col++)
            {
                if (arr2D[row, col] >= 100 || arr2D[row, col] < -9)
                {
                    Console.Write((arr2D[row, col]) + " ");
                }
                else if (arr2D[row, col] < 10)
                {
                    Console.Write((arr2D[row, col]) + "   ");
                }
                else if (arr2D[row, col] >= 10 || arr2D[row, col] < 0)
                {
                    Console.Write((arr2D[row, col]) + "  ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}