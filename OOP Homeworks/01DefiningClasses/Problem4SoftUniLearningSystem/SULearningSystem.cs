using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4SoftUniLearningSystem
{
    using Problem4SoftUniLearningSystem.Students;
    using Problem4SoftUniLearningSystem.Trainers;

    public class SULearningSystem
    {
        static void Main(string[] args)
        {
            var peoples = new List<Person>()
                              {
                                  new JuniorTrainer("Georgi", "Georgiev", 20),
                                  new OnlineStudent("Ivan", "Ivanov", 28, "3251", 4.83, "OOP"),
                                  new JuniorTrainer("Ivan", "Ivanov Jr.", 19),
                                  new SeniorTrainer("Ivan", "Ivanov Sr.", 35),
                                  new GraduateStudent("Pesho", "Peshev", 22, "1234", 5.75),
                                  new DropOutStudent("Misho", "Mihaylov", 25, "1234", 3.5, "Too few women"),
                                  new GraduateStudent("Golemets", "Golemiya", 31, "1234", 5.25),
                                  new OnsiteStudent("Stamat", "Botusharov", 23, "1234", 3.25, "OOP", 10),
                                  new OnlineStudent("Myrzeliv", "Myrzelivets", 21, "1234", 2.5, "OOP"),
                                  new OnsiteStudent("Svetlin", "Nakov", 34, "1234", 6, "OOP", 15),
                                  new OnlineStudent("Irokentij", "Portokalov", 43, "1234", 4.25, "QPC"),
                                  new OnlineStudent("Onufrij", "Popryckov", 63, "1234", 5.15, "QPC"),
                                  new OnsiteStudent("Maria", "Ivanova", 19, "1234", 5.86, "QPC", 12)
                              };

            SULSTest test = new SULSTest(peoples);

            test.PrintCurrentStudents();
        }
    }
}
