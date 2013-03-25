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
    class AnimalsTest
    {
        static void Main()
        {
            Frog[] frogs =
            {
                new Frog("Froggieta", 4, false),
                new Frog("Froggiencho", 12, false),
                new Frog("Froggitcho", 1, false),
                new Frog("Froggo", 5, false)
            }; 
                     
            Dog[] dogs =            
            {
                new Dog("Doggie", 4, false),
                new Dog("Dog", 7, false),
                new Dog("Dogo", 8, false),
                new Dog("Doger", 10, false)
            };     
             
            Cat[] cats =        
            {
                new Kitten("Kittencho", 3),
                new Tomcat("Cater", 5),
                new Kitten("Kitteny", 2),
                new Tomcat("Catten", 1)
            };                      
                                    
            dogs[1].GetAnimalType();
            cats[1].GetAnimalType();
            frogs[3].ProduceSound();

            Console.WriteLine("Average age of dogs " + Animal.AverageAge(dogs));
            Console.WriteLine("Average age of frogs " + Animal.AverageAge(frogs));
            Console.WriteLine("Average age of cats " + Animal.AverageAge(cats));
        }
    }
}
