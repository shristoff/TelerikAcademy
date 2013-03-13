/* 3.Write a method that from a given array of students finds all students 
whose first name is before its last name alphabetically. Use LINQ query operators.
   4.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
   5.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name 
and last name in descending order. Rewrite the same with LINQ.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace FindStudents
{
    public class FindStudents
    {
        //finds all students whose first name is before its last name alphabetically
        public static void FindStudentsFirstNameBeforeSecond(Student[] students)
        {
            var foundStudents = 
                from student in students
                where(student.firstName.CompareTo(student.secondName) < 0)
                select(student);
            PrintStudents(foundStudents);
        }
        //finds the first name and last name of all students with age between 18 and 24
        public static void FindStudentsBetween18And24(Student[] students)
        {
            var foundStudents =
                from student in students
                where student.age >= 18 && student.age <= 24
                select student;
            PrintStudents(foundStudents);
        }
        //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name 
        //and last name in descending order.
        public static void SortStudentsByName(Student[] students)
        {
            var sortedStudents = students.OrderByDescending(student => student.firstName).
                                          ThenByDescending(student => student.secondName);
            PrintStudents(sortedStudents);
        }
        //Rewrite previous method with LINQ
        public static void SortStudentsByNameLINQ(Student[] students)
        {
            var sortedStudents =
                from student in students
                orderby student.firstName descending, student.secondName descending
                select student;
            PrintStudents(sortedStudents);
        }
        //Print array of students
        public static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
        //main method
        static void Main()
        { //array of students
            Student[] students = {
                new Student("Ivo", "Neshev", 25),
                new Student("Nasko", "Yakov", 26),
                new Student("Dancho", "Takev", 22),
                new Student("Gogo", "Mihailov", 21),
                new Student("Nikola", "Deshev", 18),
                new Student("Yanko", "Vashev", 20),
                new Student("Pepi", "Toshev", 19),
                new Student("Nikola", "Petrov", 23),
            };
            FindStudentsFirstNameBeforeSecond(students);
            Console.WriteLine(new string('_', 30));
            FindStudentsBetween18And24(students);
            Console.WriteLine(new string('_', 30));
            SortStudentsByName(students);
            Console.WriteLine(new string('_', 30));
            SortStudentsByNameLINQ(students);
        }
    }
}
