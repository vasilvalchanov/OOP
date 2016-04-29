using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Models
{
    using CompanyHierarchy.Interfaces;

    public abstract class Person : IPerson
    {
        private int id;

        private string firstName;

        private string lastName;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < 1 || value > 150)
                {
                    throw new ArgumentOutOfRangeException("The id must be in range [1-150]");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name cannot be null");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The last name cannot be null");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("ID: {0} --> {1} {2}", this.Id, this.FirstName, this.LastName);

            return sb.ToString();
        }
    }
}
