using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Models
{
    using CompanyHierarchy.Interfaces;
     
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department = Department.Sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = new List<ISale>();
        }

        public IList<ISale> Sales { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());
            sb.AppendLine();
            sb.AppendFormat("Sales: {0}{1}", Environment.NewLine, string.Join(Environment.NewLine, this.Sales));

            return sb.ToString();
        }
    }
}
