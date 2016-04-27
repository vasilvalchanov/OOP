using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Persons
{
    public class Person
    {
        private string name;

        private int age;

        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;

        }

        public Person(string name, int age) : this(name, age, null)
        {
           
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
                    throw new ArgumentNullException("The name cannot be null or empty");
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
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("The age must be in range [1-100]");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (!string.IsNullOrEmpty(value)  && !value.Contains("@"))
                {
                    throw new ArgumentException("This is invalid email");
                }

                this.email = value;
            }
        }

        public override string ToString()
        {
            string info = string.Empty;

            info += string.Format(
                "My name is {0}. I'm {1} years old. My email is: {2}",
                this.Name,
                this.Age,
                this.Email ?? "No email.");

            return info;

        }
    }
}
