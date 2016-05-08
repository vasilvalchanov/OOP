using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2FractionCalculator
{
    class FractionCalculatorMain
    {
        static void Main(string[] args)
        { 
            var fraction1 = new Fraction(22, 7);
            var fraction2 = new Fraction(40, 4);
            var result = fraction1 + fraction2;
            var result1 = fraction1 - fraction2;
            Console.WriteLine(result.Nominator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
            Console.WriteLine(result1.Nominator);
            Console.WriteLine(result1.Denominator);
            Console.WriteLine(result1);
        }
    }
}
