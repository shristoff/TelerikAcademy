/*4.Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
  Override ToString() to display the information of a person and if age is not specified – to say so. 
  Write a program to test this functionality.*/
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int? Age 
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name)
            : this(name, null)
        {
        }

        public override string ToString()
        {
            return string.Format("Name : {0}\nAge : {1}", this.Name,
            this.Age.ToString() != string.Empty ? this.Age.ToString() : "No entered age");
        }
    }
}
