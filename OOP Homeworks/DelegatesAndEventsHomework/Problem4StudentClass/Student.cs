using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4StudentClass
{
    public delegate void OnPropertyChangedEventHandler(Student student, PropertyChangedEventArgs eventArgs);

    public class Student
    {
        public event OnPropertyChangedEventHandler PropertyChanged;

        private string name;

        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Name", this.name, value));
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 6)
                {
                    throw new ArgumentOutOfRangeException("Students age cannot be less than 6");
                }

                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Age", this.age, value));
                }

                this.age = value;
            }
        }

    }
}
