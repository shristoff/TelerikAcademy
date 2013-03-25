/*1.We are given a school. In the school there are classes of students. Each class has a set of teachers. 
 Each teacher teaches a set of disciplines. Students have name and unique class number. 
 Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures
 and number of exercises. Both teachers and students are people. Students, classes, teachers
 and disciplines could have optional comments (free text block).
 Your task is to identify the classes (in terms of OOP) and their attributes and operations, 
 encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.*/

using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class School
    {
        public string Title { get; private set; }
        public List<SchoolClass> SchoolClasses { get; private set; }

        public School(string title, List<SchoolClass> schoolClasses)
        {
            this.Title = title;
            this.SchoolClasses = new List<SchoolClass>(schoolClasses);
        }

        public override string ToString()
        {
            StringBuilder schoolInfo = new StringBuilder();
            schoolInfo.Append(Title);
            AppendListToSB.AppendList(SchoolClasses, schoolInfo);
            return schoolInfo.ToString();
        }
    }
}
