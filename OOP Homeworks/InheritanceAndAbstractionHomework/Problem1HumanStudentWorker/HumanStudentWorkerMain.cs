using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1HumanStudentWorker
{
    public class HumanStudentWorkerMain
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
                               {
                                   new Student("Vasil", "Georgiev", "1600200003"),
                                   new Student("Ivan", "Georgiev", "1600200009"),
                                   new Student("Todor", "Georgiev", "1600200006"),
                                   new Student("Vasil", "Vasilev", "1600200001"),
                                   new Student("Ivan", "Ivanov", "1600200007"),
                                   new Student("Georgi", "Petkov", "1600200005"),
                                   new Student("Mariq", "Ivanova", "1600200004"),
                                   new Student("Penka", "Georgieva", "1600200002"),
                                   new Student("Todor", "Ivanov", "1600200010"),
                                   new Student("Ivan", "Petrov", "1600200008")
                               };

            var workers = new List<Worker>()
                              {
                                  new Worker("Stoqn", "Georgiev", 222, 8),
                                  new Worker("Georgi", "Georgiev", 500, 10),
                                  new Worker("Stamat", "Ivanov", 120, 8),
                                  new Worker("Penko", "Penkov", 364, 6),
                                  new Worker("Temelko", "Ivanov", 150, 4),
                                  new Worker("Lili", "Georgieva", 700, 8),
                                  new Worker("Iva", "Todorova", 525, 10),
                                  new Worker("Nina", "Doncheva", 421, 8),
                                  new Worker("Vasil", "Milushev", 365, 6),
                                  new Worker("Evlogi", "Georgiev", 240, 8),
                              };

            foreach (var student in students.OrderBy(s => s.FacultyNumber))
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('-', 20));
            foreach (var worker in workers.OrderByDescending(w => w.MoneyPerHour()))
            {
                Console.WriteLine(worker);
            }

            var mergedList = new List<Human>();
            mergedList.AddRange(students);
            mergedList.AddRange(workers);

            Console.WriteLine(new string('-', 20));

            foreach (var human in mergedList.OrderBy(h => h.FirstName).ThenBy(h => h.LastName))
            {
                Console.WriteLine(human);
            }
        }
    }
}
