using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2BankOfCurtovoConare.Accounts
{
    public class DepositAccount : BaseAccount
    {
        public DepositAccount(CustomerType customerType, decimal balance, double interestRate, int id)
            : base(customerType, balance, interestRate, id)
        {
        }


        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("The months cannot be negative");
            }

            if (this.Balance < 1000)
            {
                return this.Balance;
            }

            decimal interest = this.Balance * (1 + (decimal)this.InterestRate * months);

            return interest;
        }
    }
}
