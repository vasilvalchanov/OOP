using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    using CompanyHierarchy.Enums;
    using CompanyHierarchy.Models;

    public class CompanyHierarchyMain
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Ivan", "Ivanov", 1230m);
            var manager = new Manager(2, "Petar", "Petrov", 2000, Department.Sales);
            var saleEmployee1 = new SalesEmployee(3, "Ivan", "Petrov", 1200);
            var saleEmployee2 = new SalesEmployee(4, "Petar", "Vasilev", 1500);
            var developer1 = new Developer(5, "Vasil", "Todorov", 2500, Department.Accounting);
            var developer2 = new Developer(6, "Todor", "Ivanov", 2300, Department.Accounting);

            manager.Employees.Add(saleEmployee1);
            manager.Employees.Add(saleEmployee2);

            var sale1 = new Sale("Laptop Lenovo", new DateTime(2016, 02, 12), 2100);
            var sale2 = new Sale("Laptop HP", new DateTime(2016, 05, 11), 1800);
            var sale3 = new Sale("HDD", new DateTime(2016, 04, 02), 300);
            saleEmployee1.Sales.Add(sale1);
            saleEmployee1.Sales.Add(sale3);
            saleEmployee2.Sales.Add(sale2);

            var project1 = new Project("New accounting system", new DateTime(2016, 04, 29), "some details", ProjectState.Open);
            var project2 = new Project("RPG Game", new DateTime(2015, 12, 01), "some details", ProjectState.Closed);
            var project3 = new Project("Photo album", new DateTime(2016, 04, 15), "some details", ProjectState.Open);
            developer1.Projects.Add(project1);
            developer1.Projects.Add(project2);
            developer2.Projects.Add(project3);

            Console.WriteLine(developer1);
            project1.CloseProject();
            project1.CloseProject();
            Console.WriteLine();

            var persons = new List<Person>()
                              {
                                  customer,
                                  manager,
                                  saleEmployee1,
                                  saleEmployee2,
                                  developer1,
                                  developer2
                              };

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
            


        }
    }
}
