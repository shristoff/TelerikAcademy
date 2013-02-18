/* We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
 of several neighbor elements located on the same line, column or diagonal. 
 Write a program that finds the longest sequence of equal strings in the matrix. */

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
        string[,] arr2D = new string[m, n];
        string equalString = "", type = "";
        int row = 0, col = 0, startRow = 0, startCol = 0, maxSequence = 0, count = 1;
        for (row = 0; row < m; row++)
        {
            Console.Write("Please enter the elements of the array by rows:\nrow {0}: ", row);
            for (col = 0; col < n; col++)
            {
                arr2D[row, col] = Console.ReadLine();
            }
            Console.WriteLine();
        }
        for (row = 0; row < m; row++)
        {
            for (col = 0; col < n; col++)
            {
                while (col + 1 < n && arr2D[row, col] == arr2D[row, col + 1])  //дясно
                {
                    count++;
                    col++;
                }
                if (count > maxSequence)
                {
                    maxSequence = count;
                    equalString = arr2D[row, col];
                    type = "row";
                }
                count = 1;
            }
        }
        for (row = 0; row < m; row++)
        {
            for (col = 0; col < n; col++)
            {
                startRow = row;
                startCol = col;
                while (row + 1 < m && col + 1 < n && arr2D[row, col] == arr2D[row + 1, col + 1])  //долу-дясно
                {
                    count++;
                    row++;
                    col++;
                }
                if (count > maxSequence)
                {
                    maxSequence = count;
                    equalString = arr2D[row, col];
                    type = "diagonal left-right";
                }
                count = 1;
                row = startRow;
                col = startCol;
            }
        }
        for (row = 0; row < m; row++)
        {
            for (col = n - 1; col >= 0; col--)
            {
                startRow = row;
                startCol = col;
                while (row + 1 < m && col > 0 && arr2D[row, col] == arr2D[row + 1, col - 1])  //долу-ляво
                {
                    count++;
                    row++;
                    col--;
                }
                if (count > maxSequence)
                {
                    maxSequence = count;
                    equalString = arr2D[row, col];
                    type = "diagonal right-left";
                }
                count = 1;
                row = startRow;
                col = startCol;
            }
        }
        for (col = 0; col < n; col++)
        {
            for (row = 0; row < m; row++)
            {
                while (row + 1 < m && arr2D[row, col] == arr2D[row + 1, col])   //долу
                {
                    row++;
                    count++;
                }
                if (count > maxSequence)
                {
                    maxSequence = count;
                    equalString = arr2D[row, col];
                    type = "column";
                }
            count = 1;
            }
        }
        Console.WriteLine("The longest line is {0} cells long, consists of \"{1}\" and is a {2}", maxSequence, equalString, type);
    }
}         
         