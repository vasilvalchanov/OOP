using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4SoftUniLearningSystem.Students
{
    public class DropOutStudent : Student
    {
        public DropOutStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string dropOutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropOutReason = dropOutReason;
        }

        public string DropOutReason { get; set; }

        public void ReAplly()
        {
            Console.WriteLine(this);
            Console.WriteLine("DropOut Reason: {0}", this.DropOutReason);
        }
    }
}
