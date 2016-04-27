using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4SoftUniLearningSystem
{
    public abstract class Student : Person
    {
        protected Student(string firstName, string lastName, int age, string studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public string StudentNumber { get; set; }

        public double AverageGrade { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());

            sb.AppendLine();
            sb.AppendFormat("Student number: {0}", this.StudentNumber);
            sb.AppendLine();
            sb.AppendFormat("Average grade: {0:F2}", this.AverageGrade);

            return sb.ToString();
        }
    }
}
