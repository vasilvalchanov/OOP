using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2BankOfCurtovoConare.Accounts
{
    public class MortgageAccount : BaseAccount
    {
        public MortgageAccount(CustomerType customerType, decimal balance, double interestRate, int id)
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
                

                if (months > 0 && months <= 12)
                {
                    interest = (this.Balance * (1 + (decimal)this.InterestRate * months)) / 2;
                }
                else
                {
                     decimal interestForFirstTwelveMonths = (this.Balance * (1 + (decimal)this.InterestRate * 12)) / 2;
                    interest = (this.Balance * (1 + (decimal)this.InterestRate * (months - 12)))
                               + interestForFirstTwelveMonths;
                }
            }
            else
            {
                if (months > 6)
                {
                    interest = this.Balance * (1 + (decimal)this.InterestRate * (months - 6));
                }
                
            }

            return interest;
        }
    }
}
