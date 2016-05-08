using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2FractionCalculator
{
    using System.Numerics;

    public struct Fraction
    {
        private const string FractionOverflowMessage =
            "Nominator or denominator are out of allow range for new fraction";


        private long denominator;

        public Fraction(long nominator, long denominator) : this()
        {
            this.Nominator = nominator;
            this.Denominator = denominator;
        }

        public long Nominator { get; set; }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("Denominator cannot be zero");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {

            long nominator = 0;
            long denominator = 0;

            try
            {
                nominator = checked((fr1.Nominator * fr2.Denominator) + (fr2.Nominator * fr1.Denominator));
                denominator = checked(fr1.Denominator * fr2.Denominator);
                
            }
            catch (OverflowException)
            {

                Console.WriteLine(FractionOverflowMessage);
            }

            return new Fraction(nominator, denominator);
        }

        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {

            long nominator = 0;
            long denominator = 0;

            try
            {
                nominator = checked((fr1.Nominator * fr2.Denominator) - (fr2.Nominator + fr1.Denominator));
                denominator = checked(fr1.Denominator * fr2.Denominator);

            }
            catch (OverflowException)
            {

                Console.WriteLine(FractionOverflowMessage);
            }

            return new Fraction(nominator, denominator);
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.Nominator / this.Denominator);
        }
    }
}
