using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Persons
{
    public class Problem1Persons
    {
        static void Main(string[] args)
        {
            Person me = new Person("Ivan", 29, "ivan.ivanov@gmail.com");
            Console.WriteLine(me);
            Person pesho = new Person("Pesho", 23);
            Console.WriteLine(pesho);
            Person gosho = new Person("Gosho", 26, "goshooooo");
            Console.WriteLine(gosho);
           
        }
    }
}
