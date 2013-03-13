using System;

namespace Points3D
{
    //3.Write a static class with a static method to calculate the distance 
    //between two points in the 3D space.
    public static class Points3DDistance
    {
        public static double GetDistance3DPoints(Point3D point1, Point3D point2)
        { 
            double distance = 0;
            distance = Math.Sqrt((point1.x - point2.x) * (point1.x - point2.x) +
                                 (point1.y - point2.y) * (point1.y - point2.y) +
                                 (point1.z - point2.z) * (point1.z - point2.z));
            return distance;
        }
    }
}
