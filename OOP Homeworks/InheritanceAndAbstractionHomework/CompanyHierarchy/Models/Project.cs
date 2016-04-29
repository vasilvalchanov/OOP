using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Models
{
    using CompanyHierarchy.Enums;
    using CompanyHierarchy.Interfaces;

    public class Project : IProject
    {
        private string name;

        private DateTime starDate;

        private string details;

        

        public Project(string name, DateTime startDate, string details, ProjectState projectState)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.ProjectState = projectState;
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
                    throw new ArgumentNullException("The project name cannot be null");
                }

                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return this.starDate;
            }
            set
            {
                if (value < new DateTime(2012, 03, 15))
                {
                    throw new ArgumentOutOfRangeException("The date cannot be befor 15.03.2012");
                }

                this.starDate = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The details cannot be null");
                }

                this.details = value;
            }
        }

        public ProjectState ProjectState { get; set; }

        public void CloseProject()
        {
            if (this.ProjectState == ProjectState.Closed)
            {
                Console.WriteLine("This project is already closed");
            }
            else
            {
                this.ProjectState = ProjectState.Closed;
                Console.WriteLine("The project was successfully closed");
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat(
                "Project name: {0}, Start date: {1}, Details: {2}, Project state: {3}",
                this.Name,
                this.StartDate.ToString("dd//MM/yyyy"),
                this.Details,
                this.ProjectState);

            return sb.ToString();
        }
    }
}
