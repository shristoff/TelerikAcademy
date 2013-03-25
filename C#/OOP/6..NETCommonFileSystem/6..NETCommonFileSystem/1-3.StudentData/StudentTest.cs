/*1.Define a class Student, which contains data about a student – first, middle and last name, SSN, 
  permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration 
  for the specialties, universities and faculties. Override the standard methods, inherited by  
  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
  2.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's 
  fields into a new object of type Student.
  3.Implement the IComparable<Student> interface to compare students by names (as first criteria, 
  in lexicographic order) and by social security number (as second criteria, in increasing order).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    class StudentTest
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
            new Student(
                "Jameson",
                "George",
                "Stuart",
                "012-213-432",
                "123 Picadilly square, London, United Kingdom",
                "020-3213-344",
                "jgs@hotmail.com",
                2,
                Speciality.Architecture,
                Faculty.Arts,
                University.Cambridge),

            new Student(
                "Peter",
                "Walker",
                "McCain",
                "012-213-436",
                "34 Downing Street, London, United Kingdom",
                "029-3442-1231",
                "PWMc@gmail.com",
                4,
                Speciality.Astronomy,
                Faculty.Environment,
                University.Harvard),
                
            new Student(
                "Layla",
                "Johnson",
                "Peterson",
                "012-213-543",
                "123 Portobello Road, London, United Kingdom",
                "159-3742-7831",
                "layla@yahoo.com",
                2,
                Speciality.Physics,
                Faculty.Engineering,
                University.Edinburgh),
                
            new Student(
                "Misha",
                "Ilarionov",
                "Moskovskii",
                "455-31-5124",
                "Tverskaya Ulitsa, Moscow, Russia",
                "449-3412-4351",
                "m.mosk@gmail.com",
                3,
                Speciality.Dentistry,
                Faculty.Medicine,
                University.Oxford),

            new Student(
                "Dasha",
                "Ivanovna",
                "Odeskaya",
                "344-45-5642",
                "345 Promorsky Bulvard, Odessa, Ukraine",
                "532-1233-8723",
                "d.odeskaya@msn.com",
                2,
                Speciality.Mathematics,
                Faculty.Engineering,
                University.Cambridge),
            };

            Console.WriteLine("Original student:\n" + students[0]);

            Student cloned = students[0].Clone();

            Console.WriteLine("Cloned student:\n{0}\n", cloned);

            Console.WriteLine("First and Cloned are the same students is {0}", students[0].Equals(cloned));

            Array.Sort(students);

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
