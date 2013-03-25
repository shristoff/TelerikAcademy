/*1.Define a class Student, which contains data about a student – first, middle and last name, SSN, 
  permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration 
  for the specialties, universities and faculties. Override the standard methods, inherited by  
  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
  2.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's 
  fields into a new object of type Student.
  3.Implement the IComparable<Student> interface to compare students by names (as first criteria, 
  in lexicographic order) and by social security number (as second criteria, in increasing order).*/

using System;
using System.Linq;
using System.Text;

namespace StudentData
{
    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private int course;
        private Speciality speciality;
        private Faculty faculty;
        private University university;

        public string FirstName
        {
            get { return firstName; }
            private set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty first name!");
                }
                firstName = value; 
            }
        }

        public string MiddleName
        {
            get { return middleName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty middle name!");
                }
                middleName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty last name!");
                }
                lastName = value;
            }
        }

        public string SSN
        {
            get { return ssn; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty number!");
                }
                ssn = value;
            }
        }

        public string PermanentAddress
        {
            get { return permanentAddress; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty address!");
                }
                permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get { return mobilePhone; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty phone!");
                }
                mobilePhone = value;
            }
        }

        public string Email
        {
            get { return email; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty email!");
                }
                email = value;
            }
        }

        public int Course
        {
            get { return course; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Course should be positive!");
                }
                course = value;
            }
        }

        public Speciality Speciality
        {
            get { return speciality; }
            private set { speciality = value; }
        }

        public Faculty Faculty
        {
            get { return faculty; }
            private set { faculty = value; }
        }

        public University University
        {
            get { return university; }
            private set { university = value; }
        }

        public Student(string firstName, string middleName, string lastName, string ssn, 
                        string permanentAddress, string mobilePhone, string email, int course,
                        Speciality speciality, Faculty faculty, University university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.Faculty = faculty;
            this.University = university;
        }
        //override Equals()
        public override bool Equals(object obj)
        {
            bool equals = false;
            //operator "as" returns null if object can't be casted to type Student
            Student other = obj as Student;
            if (other != null && this.ssn == other.ssn)
            {
                equals = true;
            }
            return equals;
        }
        //override operator ==
        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }
        //override operator !=
        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return this.ssn.GetHashCode();
        }

        public Student Clone()
        {
            return new Student(
            this.firstName, this.middleName, this.lastName, this.ssn, this.permanentAddress,
            this.mobilePhone, this.email, this.course, this.speciality, this.faculty, this.university);
        }

        object ICloneable.Clone()  // implicit implementation
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            String name = String.Format("{0}{1}{2}",
                this.firstName, this.middleName, this.lastName);

            String otherName = String.Format("{0}{1}{2}",
                other.firstName, other.middleName, other.lastName);

            int namesCompare = String.Compare(name, otherName);

            if (namesCompare != 0)
            {
                return namesCompare;
            }
            else
            {
                int ssnCompareResult = String.Compare(this.ssn, other.ssn);
                return ssnCompareResult;
            }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("Name: {0} {1} {2}\n", this.FirstName, this.MiddleName, this.LastName);
            info.AppendLine("SSN: " + this.SSN);
            info.AppendLine("Address: " + this.PermanentAddress);
            info.AppendLine("Email: " + this.Email);
            info.AppendLine("Mobile phone: " + this.MobilePhone);
            info.AppendLine("Course: " + this.Course);
            info.AppendLine("Speciality: " + this.Speciality);
            info.AppendLine("Faculty: " + this.Faculty);
            info.AppendLine("University: " + this.University);
            Console.WriteLine();

            return info.ToString().TrimEnd();
        }
    }
}
