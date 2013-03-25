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
    public class Teacher : Person, ICommentable
    {
        public List<Discipline> Disciplines { get; private set; }
        public string Comment { get; set; }
        public Teacher(string firstName, string lastName, 
            char sex, DateTime birthDate, Discipline[] disciplines)
            : base(firstName, lastName, sex, birthDate)
        { 
            this.Disciplines = new List<Discipline>(disciplines);
        }

        public override string ToString()
        {
            StringBuilder teacherInfo = new StringBuilder();
            teacherInfo.AppendFormat("\n{0}\n", base.ToString());
            AppendListToSB.AppendList<Discipline>(Disciplines, teacherInfo);
            return teacherInfo.ToString();
        }
    }
}
