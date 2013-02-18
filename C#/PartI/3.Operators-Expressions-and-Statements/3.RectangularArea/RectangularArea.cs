using System;

class RectangularArea
{
    static void Main()
    {
        Console.WriteLine("Please enter the height of the rectangular");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the width of the rectangular");
        float width = float.Parse(Console.ReadLine());
        float area = height * width;
        Console.WriteLine("The area is: {0}", area);
    }
}
