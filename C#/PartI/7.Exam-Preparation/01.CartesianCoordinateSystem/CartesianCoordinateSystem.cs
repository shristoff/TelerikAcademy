/* write a program that finds the number of the location (from 1 to 6) of the given point in the coordinate system. 
 Input data is being read from the console. The number X is on the first input line. The number Y is on the second input line. */

using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        string Xstr = Console.ReadLine();
        float x = float.Parse(Xstr);
        string Ystr = Console.ReadLine();
        float y = float.Parse(Ystr);
        byte Quadrant = 1;
        if (x > 0 && y > 0)
            Console.Write(Quadrant);
        if (x < 0 && y > 0)
            Console.Write(Quadrant + 1);
        if (x < 0 && y < 0)
            Console.Write(Quadrant + 2);
        if (x > 0 && y < 0)
            Console.Write(Quadrant + 3);
        if (x == 0 && y == 0)
            Console.WriteLine(Quadrant - 1);
        if (x == 0 && y != 0)
            Console.Write(Quadrant + 4);
        if (y == 0 && x != 0)
            Console.Write(Quadrant + 5);
    }
}
