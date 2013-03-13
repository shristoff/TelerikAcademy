/*1.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
    Implement the ToString() to enable printing a 3D point.
2.Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
Add a static property to return the point O.
3.Write a static class with a static method to calculate the distance between two points in the 3D space.
4.Create a class Path to hold a sequence of points in the 3D space. 
    Create a static class PathStorage with static methods to save and load paths from a text file. 
    Use a file format of your choice.*/

using System;

namespace Points3D
{
    public struct Point3D
    {
        //Point3D fields
        public double x;
        public double y;
        public double z;
        //private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}
        private static readonly Point3D o = new Point3D(0, 0, 0);
        //Point3D constructor
        public Point3D (double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        //static property to return the point O
        public static Point3D O 
        { 
            get { return o; }
        }
        //Implement the ToString() to enable printing a 3D point.
        public override string ToString()
        {
            string point3DStr = String.Format("{0:0.00}, {1:0.00}, {2:0.00}", 
                this.x, this.y, this.z);
            return point3DStr;
        }
    }
}
