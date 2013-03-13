/* 11.Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods 
   and holds a version in the format major.minor (e.g. 2.11). Apply the version attribute to a sample class and display
   its version at runtime. */

using System;

namespace VersionAttribute
{   
    public class VersionAttribute : System.Attribute
    {
        //field
        private string version;
        //property
        public string Version
        {
            get { return this.version; }
        }
        //constructor
        public VersionAttribute(string version)
        {
            this.version = version;
        }
    }
}
