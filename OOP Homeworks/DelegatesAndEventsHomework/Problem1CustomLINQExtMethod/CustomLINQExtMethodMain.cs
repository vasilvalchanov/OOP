using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1CustomLINQExtMethod
{
    class CustomLINQExtMethodMain
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var filteredCollection = numbers.WhereNot(x => x % 2 == 0);

            Console.WriteLine(string.Join(", ", filteredCollection));

            var students = new List<Student>()
                               {
                                   new Student("Pesho", 3),
                                   new Student("Gosho", 2),
                                   new Student("Mariika", 7),
                                   new Student("Stamat", 5)
                               };

            var max = students.Max(s => s.Grade);
            Console.WriteLine(max);
        }
    }
}
