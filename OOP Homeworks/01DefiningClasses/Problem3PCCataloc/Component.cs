using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace Problem3PCCataloc
{
    using System.Threading;

    public class Component
    {
        

        private string name;

        private string details;

        private decimal price;

        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, decimal price) : this(name, null, price)
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
                    throw new ArgumentNullException("The name cannot be null");
                }

                this.name = value;
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
                if (value == string.Empty)
                {
                    throw new ArgumentException("The details cannot be empty");
                }

                this.details = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative number");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb  = new StringBuilder();

            sb.AppendFormat("Component name: {0}", this.Name);
            sb.AppendLine();
            if (this.Details != null)
            {
                sb.AppendFormat("Details: {0}", this.Details);
                sb.AppendLine();
            }

            sb.AppendFormat("Price: {0:C}", this.Price);

            return sb.ToString();

        }
    }
}
