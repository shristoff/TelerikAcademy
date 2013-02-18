/* 14.* Write a program that reads a positive integer number N (N < 20) from console and outputs in the 
 console the numbers 1 ... N numbers arranged as a spiral. */

using System;

class ReadNPrintSpiralMatrixNxN
{
    static void Main()
    {
        Console.Write("Please enter positive integer N < 20: N = ");
        string Nstr = Console.ReadLine();
        byte N = byte.Parse(Nstr);
        int x, y;
        int i = 1;
        int digits = 3;
        if (N > 9)
            digits = 4;
        for (int quadnum = 0; quadnum <= N / 2; quadnum++)
        {
            int StartOfRow = 0 + digits * quadnum;
            int EndOfRow = digits * (N - 1 - quadnum);
            int StartOfCol = 1 + quadnum;
            int EndofCol = N - quadnum;
            if ((i == N * N) && (N % 2 == 1))
            {
                Console.SetCursorPosition(EndOfRow, StartOfCol);
                Console.Write(i);
            }
            for (x = StartOfRow, y = StartOfCol; x < EndOfRow; x = x + digits, i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(i);
            }
            for (y = StartOfCol, x = EndOfRow; y < EndofCol; y++, i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(i);
            }
            for (x = EndOfRow; x > StartOfRow; x = x - digits, i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(i);
            }
            for (y = EndofCol, x = StartOfRow; y > StartOfCol; y--, i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(i);
            }
        }
        Console.SetCursorPosition(0, 25);
    }
}