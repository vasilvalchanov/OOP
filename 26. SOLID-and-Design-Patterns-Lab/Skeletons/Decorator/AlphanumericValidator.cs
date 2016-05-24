using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Decorator
{
    using _9.Decorator.Interfaces;

    public class AlphanumericValidator : IValidator
    {
        public bool Validate(string input)
        {
            foreach (var token in input)
            {
                if (!char.IsLetterOrDigit(token))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
