using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2InterestCalculator
{
    public class InterestCalculator
    {
        public InterestCalculator(int money, double interest, int years, Func<int, double, int, string> calculateInterest )
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.CalculateInterest = calculateInterest;
        }

        public int Money { get; set; }

        public double Interest { get; set; }

        public int Years { get; set; }

        public Func<int, double, int, string> CalculateInterest { get; set; }

        public override string ToString()
        {
            return this.CalculateInterest(this.Money, this.Interest, this.Years);
        }
    }
}
