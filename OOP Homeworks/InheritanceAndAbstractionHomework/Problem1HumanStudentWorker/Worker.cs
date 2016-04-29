using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1HumanStudentWorker
{
    public class Worker : Human
    {
        private const int WorkDaysPerWeek = 5;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = (this.WeekSalary / WorkDaysPerWeek) / this.WorkHoursPerDay;

            return moneyPerHour;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine();
            sb.AppendFormat("Week salary: {0}", this.WeekSalary);
            sb.AppendLine();
            sb.AppendFormat("Workhours per day: {0}", this.WorkHoursPerDay);
            sb.AppendLine();
            sb.AppendFormat("Earned money per hour: {0:F2}", this.MoneyPerHour());

            return sb.ToString();
        }
    }
}
