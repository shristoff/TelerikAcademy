/* 1.We are given a school. In the school there are classes of students. Each class has a set of teachers. 
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
    
    class SchoolClass : ICommentable
    {
        public string ClassID { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public string Comment { get; set; }

        public SchoolClass(string classID, List<Student> students, List<Teacher> teachers)
        {
            this.ClassID = classID;
            this.Students = new List<Student>(students);
            this.Teachers = new List<Teacher>(teachers);
        }

        public override string ToString()
        {
            StringBuilder schoolClassInfo = new StringBuilder();
            schoolClassInfo.AppendFormat("\nclass {0}\n", this.ClassID);
            schoolClassInfo.AppendLine("Teachers:");
            AppendListToSB.AppendList(Teachers, schoolClassInfo);
            schoolClassInfo.AppendLine("\nStudents:");
            AppendListToSB.AppendList(Students, schoolClassInfo);
            return schoolClassInfo.ToString();
        }
    }
}
