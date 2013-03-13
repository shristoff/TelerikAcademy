/*  Create a static class PathStorage with static methods to save and load paths from a text file. 
    Use a file format of your choice.*/
using System;
using System.Collections.Generic;
using System.IO;

namespace Points3D
{
    public static class PathStorage
    {
        //method that saves a path to pathStorage.txt file (takes a path as an argument)
        public static void WritePathToFile(Path path)
        {
            StreamWriter pathWrite = new StreamWriter("../../pathStorage.txt");  //creats a new instance of streamwriter
            using (pathWrite)
            {
                foreach (Point3D point3D in path.PointSequence) //go through the points in the list
                {
                    pathWrite.WriteLine(point3D.ToString());  //write every point on a single line using overridden ToString()
                }
            }
        }
        //method that loads a path to pathStorage.txt file (returns path)
        public static Path ReadPathFromFile()
        {
            string[] coords;
            char[] separator = { ' ', ',' }; //symbols that split the string so we can extract the coords
            Point3D point3D;  //create an object point3D from type (class) Point3D 
            Path path = new Path();  //create an instance path from type (class) Path
            StreamReader pathRead = new StreamReader("../../pathStorage.txt"); //creats a new instance of streamreader
            using (pathRead)
            { 
                while (pathRead.Peek() >= 0) //while there are still chars
                {
                    coords = pathRead.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);  //splits every line in the file
                    point3D.x = double.Parse(coords[0]); //parse the number to double
                    point3D.y = double.Parse(coords[1]);
                    point3D.z = double.Parse(coords[2]);
                    path.AddPoint(point3D); //adds the point to the path
                }
            }
            return path;
        }
    }
}
