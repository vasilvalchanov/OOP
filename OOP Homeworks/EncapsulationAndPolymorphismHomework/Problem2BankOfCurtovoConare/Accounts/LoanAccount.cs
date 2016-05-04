using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2BankOfCurtovoConare.Accounts
{
    public class LoanAccount : BaseAccount
    {
        public LoanAccount(CustomerType customerType, decimal balance, double interestRate, int id)
            : base(customerType, balance, interestRate, id)
        {
        }


        public override decimal CalculateInterest(int months)
        {
            decimal interest = this.Balance;

            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("The months cannot be negative");
            }

            if (this.CustomerType == CustomerType.Companies)
            {
                if (months > 2)
                {
                    interest = this.Balance * (1 + (decimal)this.InterestRate * (months - 2));
                }
            }
            else
            {
                if (months > 3)
                {
                    interest = this.Balance * (1 + (decimal)this.InterestRate * (months - 3));
                }
            }

            return interest;
        }
    }
}
