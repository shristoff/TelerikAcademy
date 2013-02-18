/* * Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. */

using System;

class Find3x3MaxSum
{
    static void Main()
    {
        Console.Write("Enter the number of columns of the array N > 3: ");
        string nStr = Console.ReadLine();
        int n = int.Parse(nStr);
        Console.Write("Enter the number of rows of the array M > 3: ");
        string mStr = Console.ReadLine();
        int m = int.Parse(mStr);
        int[,] arr2D = new int[m,n];
        int[,] arrMaxSum = new int[3, 3];
        int row = 0, col = 0, sum = 0, maxSum = Int32.MinValue, count = 1;
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
        for (row = 1; row + 1 < m; row++)
        {
            for (col = 1; col + 1 < n; col++)
            {
                sum = arr2D[row - 1, col - 1] + arr2D[row - 1, col] + arr2D[row - 1, col + 1] +
                      arr2D[row, col - 1] + arr2D[row, col] + arr2D[row, col + 1] +
                      arr2D[row + 1, col - 1] + arr2D[row + 1, col] + arr2D[row + 1, col + 1];
                if (sum == maxSum)
                    count++;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    arrMaxSum[0, 0] = arr2D[row - 1, col - 1];
                    arrMaxSum[0, 1] = arr2D[row - 1, col];
                    arrMaxSum[0, 2] = arr2D[row - 1, col + 1];
                    arrMaxSum[1, 0] = arr2D[row, col - 1];
                    arrMaxSum[1, 1] = arr2D[row, col];
                    arrMaxSum[1, 2] = arr2D[row, col + 1];
                    arrMaxSum[2, 0] = arr2D[row + 1, col - 1];
                    arrMaxSum[2, 1] = arr2D[row + 1, col];
                    arrMaxSum[2, 2] = arr2D[row + 1, col + 1];
                    count = 1;
                }
             }
        }
        Console.WriteLine("The array you entered is:"); 
        Print(arr2D);
        Console.WriteLine("The 3x3 square with max sum is:");
        Print(arrMaxSum);
        Console.WriteLine("The sum of the square is: {0}\nThere is/are {1} 3x3 square(s) with the same sum", maxSum, count);
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
