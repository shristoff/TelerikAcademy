/*8.Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
  9.Implement an indexer this[row, col] to access the inner matrix cells.
 10.Implement the operators + and - (addition and subtraction of matrices of the same size)
 and * for matrix multiplication. Throw an exception when the operation cannot be performed. 
 Implement the true operator (check for non-zero elements).*/

using System;

namespace Matrix
{
    class Matrix<T>
        where T: struct
    {
        //fields for rows, columns and matrix T[,] 
        private readonly int rows;
        private readonly int cols;
        private T[,] matrix;
        //properties
        public int Rows
        { get { return rows; } }

        public int Cols
        { get { return cols; } }
        //constructor
        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            if (rows < 1 && cols < 1)
                throw new ArgumentException("Matrix should have at least one element");
            this.matrix = new T[rows, cols]; 
        }
        //indexer (property)
        public T this[int row, int col]
        {
            get 
            {
                if (row < 0 || col < 0 || row > rows || col > cols)
                {
                    throw new IndexOutOfRangeException();
                }
                return matrix[row, col];
            }
            set
            {
                if (row < 0 || col < 0 || row > rows || col > cols)
                {
                    throw new IndexOutOfRangeException();
                }
                matrix[row, col] = value;
            }
        }
        //overloads operator plus
        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            Matrix<T> matrixSum = new Matrix<T>(matrix1.rows, matrix1.cols);
            if (matrix1.rows == matrix2.rows && matrix1.cols == matrix2.cols)
            {
                for (int row = 0; row < matrix1.rows; row++)
                {
                    for (int col = 0; col < matrix1.cols; col++)
                    {
                        try
                        {
                            checked
                            {
                                matrixSum[row, col] = (dynamic)matrix1[row, col] + matrix2[row, col];
                            }
                        }
                        catch (System.OverflowException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                }
                return matrixSum;
            }
            else
                throw new ArgumentException("Matrices should have the same size!");
        }
        //overload operator minus
        public static Matrix<T> operator -(Matrix<T> minuend, Matrix<T> subtrahend)
        {
            Matrix<T> matrixDifference = new Matrix<T>(minuend.rows, minuend.cols);
            if (minuend.rows == subtrahend.rows && minuend.cols == subtrahend.cols)
            {
                for (int row = 0; row < minuend.rows; row++)
                {
                    for (int col = 0; col < minuend.cols; col++)
                    {
                        try
                        {
                            checked
                            {
                                matrixDifference[row, col] = (dynamic)minuend[row, col] - subtrahend[row, col];
                            }
                        }
                        catch (System.OverflowException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                }
                return matrixDifference;
            }
            else
                throw new ArgumentException("Matrices should have the same size!");
        }
        //overload operator *
        public static Matrix<T> operator *(Matrix<T> factor1, Matrix<T> factor2)
        {
            Matrix<T> matrixProduct = new Matrix<T>(factor1.rows, factor2.cols);
            if (factor1.cols == factor2.rows)
            {
                for (int row = 0; row < matrixProduct.rows; row++)
                {
                    for (int col = 0; col < matrixProduct.cols; col++)
                    {
                        matrixProduct[row, col] = default(T);
                        for (int i = 0; i < factor1.cols; i++)
                        {
                            try
                            {
                                checked
                                {
                                    matrixProduct[row, col] = matrixProduct[row, col] + 
                                        (dynamic)factor1[row, i]*factor2[i, col];
                                }
                            }
                            catch (System.OverflowException e)
                            {
                                Console.WriteLine(e.ToString());
                            }
                        }
                    }
                }
                return matrixProduct;
            }
            else
                throw new ArgumentException("Matrices should have valid size!");
        }
        //overload true operator
        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (!matrix[row, col].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //overload false operator
        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (!matrix[row, col].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
