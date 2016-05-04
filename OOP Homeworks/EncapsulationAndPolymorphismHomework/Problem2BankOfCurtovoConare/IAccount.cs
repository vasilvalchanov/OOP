using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2BankOfCurtovoConare
{
    public interface IAccount
    {
         int Id { get; set; }

         CustomerType CustomerType { get; set; }

         decimal Balance { get; set; }

         double InterestRate { get; set; }

        void MakeDeposit(decimal money);

        void WithdrawMoney(decimal money);

        decimal CalculateInterest(int months);
    }
}
