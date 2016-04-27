using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4SoftUniLearningSystem
{
    using Problem4SoftUniLearningSystem.Students;

    public class SULSTest
    {

        public SULSTest(IList<Person> peoples)
        {
            this.Database = peoples;
        }

        public IList<Person> Database { get; set; }

        public void PrintCurrentStudents()
        {
            foreach (var person in this.Database.Where(p => p is CurrentStudent).Cast<CurrentStudent>().OrderByDescending(st => st.AverageGrade))
            {
                Console.WriteLine(person);
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}
