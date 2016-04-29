using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Models
{
    using CompanyHierarchy.Interfaces;

    public class Sale : ISale
    {
        private string productName;

        private DateTime date;

        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name cannot be null");
                }

                this.productName = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                if (value < new DateTime(2012, 03, 15))
                {
                    throw new ArgumentOutOfRangeException("The date cannot be befor 15.03.2012");
                }

                this.date = value;
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
            return string.Format("Product: {0}, Date of sale: {1}, Price: {2}", this.ProductName, this.Date.ToString("dd//MM/yyyy"), this.Price);
        }
    }
}
