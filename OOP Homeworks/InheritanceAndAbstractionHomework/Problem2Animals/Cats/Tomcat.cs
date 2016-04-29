using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2Animals.Cats
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, Gender gender = Gender.Male)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The tomcat {0} says: Mua Mua", this.Name);
        }
    }
}
