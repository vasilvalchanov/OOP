using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2InterestCalculator
{
    class InterestCalculatorMain
    {
        static void Main(string[] args)
        {
            var calculator = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine(calculator);

            var calculator1 = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            Console.WriteLine(calculator1);
        }

        public static string GetSimpleInterest(int money, double interest, int years)
        {
            return string.Format("{0:F4}", money * (decimal)(1 + (interest / 100 * years)));
        }

        public static string GetCompoundInterest(int money, double interest, int years)
        {
            return string.Format("{0:F4}", money * (Math.Pow(1 + interest / 100 / 12, years * 12)));
        }
    }
}
