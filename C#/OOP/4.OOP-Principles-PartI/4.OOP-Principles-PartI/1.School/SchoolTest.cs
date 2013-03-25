using System;
using System.Collections.Generic;

namespace School
{
    class SchoolTest
    {
        static void Main()
        {
            List<Student> students1 = new List<Student>
            {
                new Student("Gosho", "Petrov", 100, 'm', new DateTime(1992,2,24)),
                new Student("Ivana", "Gogova", 101, 'f', new DateTime(1993,3,22)),
                new Student("Ivo", "Dachev", 102, 'm', new DateTime(1994,5,4)),
                new Student("Petar", "Gulev", 103, 'm', new DateTime(1991,1,6)),
                new Student("Vasil", "Yanchev", 104, 'm', new DateTime(1993,2,27)),
                new Student("Vlado", "Metodiev", 105, 'm', new DateTime(1992,6,13)),
                new Student("Iva", "Pareva", 106, 'f', new DateTime(1991,9,10))
            };

            List<Student> students2 = new List<Student>
            {
                new Student("Penka", "Totova", 100, 'f', new DateTime(1991,5,14)),
                new Student("Jana", "Petrova", 101, 'f', new DateTime(1993,3,22)),
                new Student("Gergana", "Dancheva", 102, 'f', new DateTime(1994,3,12)),
                new Student("Ivan", "Pulev", 103, 'm', new DateTime(1992,6,16)),
                new Student("Stefan", "Yankov", 104, 'm', new DateTime(1994,3,7)),
                new Student("Misho", "Petrov", 105, 'm', new DateTime(1991,7,23)),
                new Student("Ivayla", "Paneva", 106, 'f', new DateTime(1997,5,11))
            };

            Discipline[] webDesign = new Discipline[]
            {
                new Discipline("HTML", 6, 6),
                new Discipline("CSS", 5, 5),
                new Discipline("JavaScript", 9, 9),
                new Discipline("LESS", 8, 8)
            };

            Discipline[] programming = new Discipline[]
            {
                new Discipline("C# Fundamentals Part I", 5, 2),
                new Discipline("C# Fundamentals Part II", 5, 5),
                new Discipline("Object-Oriented Programming", 7, 9),
                new Discipline("Data Structures", 8, 8)
            };

            Discipline[] knowledgeSharing = new Discipline[]
            {
                new Discipline("Essay", 1, 1),
                new Discipline("MindMapping", 2, 1),
                new Discipline("TeamWork", 9, 9),
            };

            List<Teacher> teachers1 = new List<Teacher>
            {
                new Teacher("Ivo", "Ivanov", 'm', new DateTime(1990, 12, 23), webDesign),
                new Teacher("Anastasia", "Mitrova", 'f', new DateTime(1987, 10, 21), programming)
            };

            List<Teacher> teachers2 = new List<Teacher>
            {
                new Teacher("Iva", "Petrova", 'f', new DateTime(1986, 6, 13), knowledgeSharing),
                new Teacher("Angel", "Hristov", 'm', new DateTime(1989, 3, 1), programming)
            };

            List<SchoolClass> schoolClasses = new List<SchoolClass>
            {
                new SchoolClass("10A", students1, teachers1),
                new SchoolClass("11D", students2, teachers2)
            };

            School softwareUniversity = new School("Software University", schoolClasses);
            Console.Write(softwareUniversity);
        }
    }
}
