/* Write a program that prints on the console the border of a trapezoid by given number N.
The width of the top side of the trapezoid must be exactly N.
The width of the bottom side of the trapezoid must be exactly 2 * N.
The height of the trapezoid must be exactly N + 1.
Also the top right and the bottom right angle of the trapezoid must be equal to 90 degrees */

using System;

class Trapezoid
{
    static void Main()
    {
        string Nstr = Console.ReadLine();
        int N = byte.Parse(Nstr);
        char Star = '*';
        string Left = new String('.', N);
        string TopDownSide = new String(Star, N);
        Console.Write(Left);
        Console.WriteLine(TopDownSide);
        for (int j = N + 1; j < 2*N; j++)
        {
            Left = new String('.', 2*N - j);
            string Right = new String('.', j - 2);
            Console.WriteLine(Left + Star + Right + Star);
        }
        TopDownSide = new String(Star, 2*N);
        Console.WriteLine(TopDownSide);
    }
}