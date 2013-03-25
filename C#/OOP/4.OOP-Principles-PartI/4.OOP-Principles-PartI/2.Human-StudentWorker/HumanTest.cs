/*2.Define abstract class Human with first name and last name. Define new class Student which is derived from Human 
 and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
 and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors 
 and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order 
 (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in 
 descending order. Merge the lists and sort them by first name and last name. */

using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanStudentWorker
{
    class HumanTest
    {
        static void Main()
        {
            List<Student> students = CreateStudentsList();

            List<Worker> workers = CreateWorkersList();
            //order with lambda expression
            List<Student> orderedStudents = students.OrderBy(student => student.Grade).ToList();
            PrintList(orderedStudents);
            //order with LINQ
            var orderedWorkers =
                from worker in workers
                orderby worker.MoneyPerHour()
                select worker;
            PrintList(orderedWorkers);

            List<Human> all = new List<Human>(students);
            List<Human> humanWorkers = new List<Human>(workers);

            all = all.Concat(humanWorkers).ToList();

            var orderedAll =
                from human in all
                orderby human.FirstName, human.LastName
                select human;

            PrintList(orderedAll);
        }

        public static void PrintList(IEnumerable<Human> humans)
        {
            foreach (Human human in humans)
            {
                Console.WriteLine(human.ToString());
            }
            Console.WriteLine(new string('=', 40));
        }

        private static List<Worker> CreateWorkersList()
        {
            List<Worker> workers = new List<Worker>
            {
                new Worker("Gosho", "Petrov", 120, 8),
                new Worker("Ivana", "Gogova", 130, 6),
                new Worker("Ivo", "Dachev", 100, 10),
                new Worker("Petar", "Gulev", 190, 9),
                new Worker("Vasil", "Yanchev", 90, 8),
                new Worker("Vlado", "Metodiev", 220,5),
                new Worker("Iva", "Pareva", 240, 3),
                new Worker("Sergey", "Vladev", 300, 2),
                new Worker("Ivancho", "Donev", 70, 11),
                new Worker("Petar", "Gatev", 250, 5)
            };
            return workers;
        }

        private static List<Student> CreateStudentsList()
        {
            List<Student> students = new List<Student>
            {
                new Student("Dosho", "Vetrov", 4.50),
                new Student("Riana", "Dogova", 3.70),
                new Student("Nivo", "Vachev", 5.60),
                new Student("Retar", "Julev", 5.80),
                new Student("Dasil", "Banchev", 4.30),
                new Student("Flado", "Metodiev", 3.40),
                new Student("Diva", "Pareva", 5.90),
                new Student("Bergen", "Vladev", 4.10),
                new Student("Jogno", "Donev", 5.90),
                new Student("Detko", "Gatev", 5.20)
            };
            return students;
        }
    }
}
