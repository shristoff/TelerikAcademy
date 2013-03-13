using System;

namespace FindStudents
{
    public class Student
    {
        //properties
        public string firstName { get; set; }
        public string secondName { get; set; }
        public int age { get; set; }
        //constructor
        public Student(string firstName, string secondName, int age)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;
        }
        //override ToString()
        public override string ToString()
        {
            return String.Format("{0} {1}, age {2}", this.firstName, this.secondName, this.age);
        }
    }
}
