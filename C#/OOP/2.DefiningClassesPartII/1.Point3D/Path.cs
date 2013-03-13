using System;
using System.Collections.Generic;

namespace Points3D
{
    //4.Create a class Path to hold a sequence of points in the 3D space. 
    public class Path
    {
        //private field - list of 3D points creates a new instance
        private List<Point3D> pointSequence = new List<Point3D>();
        public List<Point3D> PointSequence
        {
            get { return this.pointSequence; }
            set { this.pointSequence = value; }
        }
        //method to add points in the list
        public void AddPoint(Point3D point3D)
        {
            pointSequence.Add(point3D);
        }
        //method to print a path
        public void PrintPath(Path path)
        {
            foreach (Point3D point3D in path.PointSequence)
            {
                Console.WriteLine(point3D.ToString());
            }
        }
    }
}
