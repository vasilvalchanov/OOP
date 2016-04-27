using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4SoftUniLearningSystem.Students
{
     public abstract class CurrentStudent : Student
    {
         protected CurrentStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse)
             : base(firstName, lastName, age, studentNumber, averageGrade)
         {
             this.CurrentCourse = currentCourse;
         }

         public string CurrentCourse { get; set; }

         public override string ToString()
         {
             StringBuilder sb = new StringBuilder(base.ToString());
             sb.AppendLine();
             sb.AppendFormat("Current course: {0}", this.CurrentCourse);

             return sb.ToString();

         }
    }
}
