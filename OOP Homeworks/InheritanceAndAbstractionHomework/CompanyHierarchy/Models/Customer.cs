using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Models
{
    using CompanyHierarchy.Interfaces;

    public class Customer : Person, ICustomer
    {
        private decimal balance;

        public Customer(int id, string firstName, string lastName, decimal balance)
           : base(id, firstName, lastName)
        {
            this.Balance = balance;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The balance cannot be negative number");
                }

                this.balance = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());

            sb.AppendLine();
            sb.AppendFormat("Balance: {0:F2}", this.Balance);

            return sb.ToString();
        }
    }
}
