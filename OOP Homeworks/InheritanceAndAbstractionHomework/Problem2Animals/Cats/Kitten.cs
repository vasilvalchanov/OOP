using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2Animals.Cats
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, Gender gender = Gender.Female)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("The kitten {0} says: Mrr Mrr", this.Name);
        }
    }
}
