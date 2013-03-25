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
    public abstract class Person
    {
        //properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public char Sex { get; private set; }
        public DateTime BirthDate { get; private set; }
        //constructor for person
        public Person(string firstName, string lastName, 
            char sex = default(char), DateTime birthDate = default(DateTime))
        {
            if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName)
                || (sex != 'm' && sex != 'f'))
                throw new ArgumentNullException("Invalid name(s) or sex");
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Sex = sex;
            this.BirthDate = birthDate;
        }
        //method that returns the age of the person
        private int GetAge(DateTime birthDate)
        {
            int age = (DateTime.Now - birthDate).Days;
            return age/365;
        }
        //override ToString()
        public override string ToString()
        {
            return String.Format("{0} {1}, sex {2}, age {3}", 
                FirstName, LastName, Sex, GetAge(BirthDate));
        }
    }
}
