using System;
using System.Collections.Generic;

namespace Points3D
{
    class TestPoint3D
    {
        static void Main()
        {
            Point3D point1 = new Point3D(0.4, 1.5, 2.34);  //creates some new points
            Point3D point2 = new Point3D(1.6, 2.5, 3.67);
            Point3D point3 = new Point3D(-2.56, -5, -1.4);
            Point3D point4 = new Point3D(2.3, 6, -4.2);
            Console.WriteLine(point1.ToString());  //prints one of the points to test overridden ToString() method
            //prints the calculated distance between two points
            Console.WriteLine("The distance between point1 and point4 is: {0:0.00}", Points3DDistance.GetDistance3DPoints(point1, point4));
            Path path = new Path(); //creates a new instance path of type (class) Path
            path.AddPoint(point1); //adds points to the path
            path.AddPoint(point2);
            path.AddPoint(point3);
            path.AddPoint(point4);
            PathStorage.WritePathToFile(path);  //writes the path to a file using the method
            path.PrintPath(PathStorage.ReadPathFromFile()); //prints the read path from a file, so we can test what had been read
        }
    }
}
