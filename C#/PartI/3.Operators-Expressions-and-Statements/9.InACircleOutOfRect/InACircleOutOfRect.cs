using System;

class InACircleOutOfRect
{
    static void Main()
    {
        Console.Write("Please enter the x coordinate of the point x = ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Please enter the y coordinate of the point y = ");
        float y = float.Parse(Console.ReadLine());
        bool z = (((x - 1)*(x - 1) + (y - 1)*(y - 1)) <= 9) && ((x < -1) || ((x >= -1) && ((y <= -1) || (y >= 1))));
        Console.WriteLine("\"The point is inside or on the circle and out of the rectangular\" is: {0}", z);
    }
}