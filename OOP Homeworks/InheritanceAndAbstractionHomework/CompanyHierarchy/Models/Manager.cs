using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Models
{
    using CompanyHierarchy.Interfaces;

    public class Manager : Employee, IManager
    {
        public Manager(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = new List<IEmployee>();
        }

        public IList<IEmployee> Employees { get; set; }

        public override string ToString()
        {
            var employeesName = this.Employees.Select(e => new { e.FirstName, e.LastName }).ToList();
            var sb = new StringBuilder(base.ToString());
            sb.AppendLine();
            sb.AppendFormat("Employess under his command: {0}", Environment.NewLine);

            foreach (var employee in employeesName)
            {
                sb.AppendFormat("{0} {1}", employee.FirstName, employee.LastName);
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
