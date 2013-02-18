using System;

class CheckIfxyAreInCircle
{
    static void Main()
    {
        Console.Write("Please enter the x coordinate of the point x = ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Please enter the y coordinate of the point y = ");
        float y = float.Parse(Console.ReadLine());
        bool z = ((x * x) + (y * y)) <= 25;
        Console.WriteLine("\"The point is inside or on the circle\" is: {0}", z);
    }
}