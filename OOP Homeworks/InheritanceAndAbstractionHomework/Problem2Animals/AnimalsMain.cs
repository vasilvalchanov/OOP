using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2Animals
{
    using Problem2Animals.Cats;

    public class AnimalsMain
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Sharo", 3, Gender.Male);
            var dog1 = new Dog("Pumiar", 9, Gender.Male);
            dog.ProduceSound();
            var frog = new Frog("Jabcho", 2, Gender.Male);
            var frog1 = new Frog("Cermit", 4, Gender.Male);
            frog.ProduceSound();
            var tomcat = new Tomcat("Tom", 5);
            var tomcat1 = new Tomcat("Garfield", 1);
            tomcat.ProduceSound();
            var kitten = new Kitten("Kitty", 2);
            var kitten1 = new Kitten("Sarra", 7);
            kitten.ProduceSound();

            Animal[] animals = { dog, dog1, frog, frog1, tomcat, tomcat1, kitten, kitten1 };

            double dogsAverageAge = animals.Where(a => a is Dog).Average(a => a.Age);
            double frogsAverageAge = animals.Where(a => a is Frog).Average(a => a.Age);
            double kittensAverageAge = animals.Where(a => a is Kitten).Average(a => a.Age);
            double tomcatsAverageAge = animals.Where(a => a is Tomcat).Average(a => a.Age);

            Console.WriteLine("Dogs average age is {0:F2}", dogsAverageAge);
            Console.WriteLine("Frogs average age is {0:F2}", frogsAverageAge);
            Console.WriteLine("Tomcats average age is {0:F2}", tomcatsAverageAge);
            Console.WriteLine("Kittens average age is {0:F2}", kittensAverageAge);
        }
    }
}
