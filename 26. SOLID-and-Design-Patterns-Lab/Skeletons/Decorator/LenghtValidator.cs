using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Decorator
{
    using _9.Decorator.Interfaces;

    public class LenghtValidator : IValidator
    {
        private int minLenght;

        private int maxLenght;

        public LenghtValidator(int minLenght, int maxLenght)
        {
            this.minLenght = minLenght;
            this.maxLenght = maxLenght;
        }

        public bool Validate(string input)
        {
            if (input.Length < this.minLenght || input.Length > this.maxLenght)
            {
                return false;
            }

            return true;
        }
    }
}
