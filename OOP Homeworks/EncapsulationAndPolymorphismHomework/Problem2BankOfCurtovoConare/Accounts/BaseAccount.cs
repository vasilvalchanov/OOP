using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2BankOfCurtovoConare.Accounts
{
    public abstract class BaseAccount : IAccount
    {
        private double interestRate;

        protected BaseAccount(CustomerType customerType, decimal balance, double interestRate, int id = 0)
        {
            this.Id = id;
            this.CustomerType = customerType;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public int Id { get; set; }

        public CustomerType CustomerType { get; set; }

        public decimal Balance { get; set; }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The interest rate cannot be negative");
                }

                this.interestRate = value;
            }
        }

        public virtual void MakeDeposit(decimal money)
        {
            this.Balance += money;
        }

        public abstract decimal CalculateInterest(int months);

        public virtual void WithdrawMoney(decimal money)
        {
            if (this.GetType().Name != "DepositAccount")
            {
                throw new InvalidOperationException("Only deposit account has option for withdrawing money");
            }

            if (money > this.Balance)
            {
                throw new InvalidOperationException("Cannot withdraw more money than there are in balance. Balance: " + this.Balance);
            }

            this.Balance -= money;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat(
                "{0} --> AccountType {1} --> Customer type {2} --> Balance {3:F2} --> Interest rate {4:F2}",
                this.Id,
                this.GetType().Name,
                this.CustomerType,
                this.Balance,
                this.InterestRate);

            return sb.ToString();
        }
    }
}
