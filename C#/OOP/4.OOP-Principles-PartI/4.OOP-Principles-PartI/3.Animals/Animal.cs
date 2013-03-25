/*3.Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
  Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
  Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female 
  and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of animals 
  and calculate the average age of each kind of animal using a static method (you may use LINQ).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private bool isMale;

        public string Name 
        { 
            get
            {
                return name;
            }

            protected set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter valid name!");
                }
                name = value;
            }
        }

        public int Age
        { 
            get
            {
                return age;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                age = value;
            }
        }

        public bool IsMale
        {
            get
            {
                return isMale;
            }
            protected set
            {
                isMale = value;
            }
        }

        public Animal(string name, int age, bool isMale)
        { 
            this.Name = name;
            this.Age = age; 
            this.IsMale = isMale;
        }

        public void GetAnimalType()
        {
            Console.WriteLine("I am " + GetType().Name);
        }

        public static double AverageAge(Animal[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i].Age;
            }
            return sum / array.Length;
        }
    }
}
