using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFootball.Models
{
    public class Player
    {
        private const int MinimumAllowedYear = 1980;
        private string firstName;

        private string lastName;

        private decimal salary;

        private DateTime dateOfBirth;



        public Player(string firstName, string lastName, decimal salary, DateTime dateOfBirth, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.DateOfBirth = dateOfBirth;
            this.Team = team;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("The name must be at least 3 symbols long");
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
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("The name must be at least 3 symbols long");
                }

                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The salary cannot be negavite");
                }

                this.salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            set
            {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentOutOfRangeException("Date of birth cannot be earlier than " + MinimumAllowedYear);
                }

                this.dateOfBirth = value;
            }
        }

        public Team Team { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat(
                "{0} {1} --> born in {2}",
                this.FirstName,
                this.LastName,
                this.DateOfBirth.ToString("dd/MM/yyyy"));
            return sb.ToString();
        }
    }
}
