/*1.We are given a school. In the school there are classes of students. Each class has a set of teachers. 
 Each teacher teaches a set of disciplines. Students have name and unique class number. 
 Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures
 and number of exercises. Both teachers and students are people. Students, classes, teachers
 and disciplines could have optional comments (free text block).
 Your task is to identify the classes (in terms of OOP) and their attributes and operations, 
 encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.*/

using System;

namespace School
{
    public class Discipline : ICommentable
    {
        public string Name { get; private set; }
        public int ExercisesHours { get; private set; }
        public int LecturesHours { get; private set; }
        public string Comment { get; set; }

        public Discipline(string name, int lecturesHours, int exercisesHours)
        {
            if (lecturesHours < 0 || exercisesHours < 0 || String.IsNullOrEmpty(name))
                throw new ArgumentOutOfRangeException("Invalid input!");
            this.Name = name;
            this.LecturesHours = lecturesHours;
            this.ExercisesHours = exercisesHours;
        }

        public override string ToString()
        {
            return String.Format("Discpiline: {0}, lectures: {1}h, exercises {2}h\n", 
                this.Name, this.LecturesHours, this.ExercisesHours);
        }
    }
}
