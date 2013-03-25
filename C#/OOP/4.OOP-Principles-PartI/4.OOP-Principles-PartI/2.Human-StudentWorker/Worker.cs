/*2.Define abstract class Human with first name and last name. Define new class Student which is derived from Human 
 and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
 and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors 
 and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order 
 (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in 
 descending order. Merge the lists and sort them by first name and last name. */

using System;

namespace HumanStudentWorker
{
    public class Worker : Human
    {
        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return (double)this.WeekSalary / 5 / this.WorkHoursPerDay;        
        }

        public override string ToString()
        {
            return String.Format("{0}, money per hour: {1:0.00}", base.ToString(), MoneyPerHour());
        }
    }
}
