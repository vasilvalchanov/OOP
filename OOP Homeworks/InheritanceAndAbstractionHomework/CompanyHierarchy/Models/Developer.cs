using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Models
{
    using CompanyHierarchy.Interfaces;

    public class Developer : RegularEmployee, IDeveloper
    {
        public Developer(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = new List<IProject>();
        }

        public IList<IProject> Projects { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());
            sb.AppendLine();
            sb.AppendFormat("Projects: {0}{1}", Environment.NewLine, string.Join(Environment.NewLine, this.Projects));

            return sb.ToString();
        }
    }
}
