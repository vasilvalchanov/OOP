using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2BankOfCurtovoConare
{
    using Problem2BankOfCurtovoConare.Accounts;

    public class BankEngine
    {
        private IList<IAccount> accounts;

        public BankEngine(IList<IAccount> accounts)
        {
            this.accounts = accounts;
        }

        public BankEngine()
        {
            this.accounts = new List<IAccount>();
        }

        public IEnumerable<IAccount> Accounts
        {
            get
            {
                return this.accounts;
            }
        }

        public void AddAccount(IAccount account)
        {
            if (account == null)
            {
                throw new ArgumentNullException("The account cannot be null");
            }

            this.accounts.Add(account);

        }

        public void Run()
        {
            string input = Console.ReadLine();

            do
            {
                try
                {
                    string result = ExecuteCommand(input);

                    Console.WriteLine(result);
                    Console.WriteLine(new string('=', 25));
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentNullException ex)
                {

                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }
            while (input != "End");
        }

        private string ExecuteCommand(string input)
        {
            var commandLine = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = commandLine[0];

            string result = string.Empty;

            switch (command)
            {
                case "Create":
                    result = CreateAccount(commandLine);
                    break;
                case "Withdraw":
                    result = WithdrawMoney(commandLine);
                    break;
                case "Deposit":
                    result = DepositMoney(commandLine);
                    break;
                case "Calculate":
                    result = CalculateInterest(commandLine);
                    break;
                case "Status":
                    result = Status();
                    break;
                default: throw new ArgumentException("Invalid command");
            }

            return result;
        }

        private string Status()
        {
            var sb = new StringBuilder();
            foreach (var account in this.Accounts.OrderBy(a => a.Id))
            {
                sb.AppendLine(account.ToString());
            }

            return sb.ToString();
        }

        private string CalculateInterest(string[] commandLine)
        {
            var months = int.Parse(commandLine[1]);
            var accountId = int.Parse(commandLine[2]);

            var account = this.Accounts.FirstOrDefault(id => id.Id == accountId);

            if (account == null)
            {
                throw new ArgumentNullException("There is no account with such Id");
            }

            var interest = account.CalculateInterest(months);

            return string.Format(
                "Interest for account with ID {0} for {1} months is {2:F2}",
                account.Id,
                months,
                interest);
        }

        private string DepositMoney(string[] commandLine)
        {
            var money = decimal.Parse(commandLine[1]);
            var accountId = int.Parse(commandLine[2]);

            var account = this.Accounts.FirstOrDefault(id => id.Id == accountId);

            if (account == null)
            {
                throw new ArgumentNullException("There is no account with such Id");
            }

            account.MakeDeposit(money);

            string result = string.Format(
                "It was made deposit for account with ID {0} with {1} money",
                account.Id,
                money);

            return result;
        }

        private string WithdrawMoney(string[] commandLine)
        {
            var money = decimal.Parse(commandLine[1]);
            var accountId = int.Parse(commandLine[2]);

            var account = this.Accounts.FirstOrDefault(id => id.Id == accountId);

            if (account == null)
            {
                throw new ArgumentNullException("There is no account with such Id");
            }


            account.WithdrawMoney(money);

            string result = string.Format(
                "It was made withdrawing for account with ID {0} with {1} money",
                account.Id,
                money);

            return result;
        }

        private string CreateAccount(string[] commandLine)
        {
            var accountType = commandLine[1];
            var customerType = commandLine[2];
            var balance = decimal.Parse(commandLine[3]);
            var interestRate = double.Parse(commandLine[4]);

            var customerTypeEnum = (CustomerType)Enum.Parse(typeof(CustomerType), customerType);
            IAccount account = null;
            int currentId = this.Accounts.Count() + 1;

            switch (accountType)
            {
                case "deposit":
                    account = new DepositAccount(customerTypeEnum, balance, interestRate, currentId);
                    break;
                case "loan":
                    account = new LoanAccount(customerTypeEnum, balance, interestRate, currentId);
                    break;
                case "mortgage":
                    account = new MortgageAccount(customerTypeEnum, balance, interestRate, currentId);
                    break;
                default: throw new ArgumentException("Invalid account type");

            }

            this.AddAccount(account);

            string result =
                string.Format(
                    "New {0} with balance {1:F2} and interest rate {2:F2} was successfully created",
                    account.GetType().Name,
                    account.Balance,
                    account.InterestRate);

            return result;

        }
    }
}
