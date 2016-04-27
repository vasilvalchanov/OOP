using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4SoftUniLearningSystem.Students
{
    public class OnsiteStudent : CurrentStudent
    {
        public OnsiteStudent(
            string firstName,
            string lastName,
            int age,
            string studentNumber,
            double averageGrade,
            string currentCourse,
            int numberOfVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());

            sb.AppendLine();
            sb.AppendFormat("Number of visits: {0}", this.NumberOfVisits);

            return sb.ToString();
        }
    }
}
