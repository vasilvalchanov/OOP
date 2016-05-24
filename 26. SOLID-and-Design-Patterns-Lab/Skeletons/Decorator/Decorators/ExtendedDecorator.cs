using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Decorator.Decorators
{
    using _9.Decorator.Interfaces;

    public class ExtendedDecorator : BaseDecorator
    {
        private IValidator[] validators; 

        public ExtendedDecorator(IValidator validator, params IValidator[] validators)
            : base(validator)
        {
            this.validators = validators;
        }

        public override bool Validate(string input)
        {
            var isValidBaseValidator = this.validator.Validate(input);
            var isValid = false;

            foreach (var validator in this.validators)
            {
                isValid = validator.Validate(input);

                if (!isValid)
                {
                    return false;
                }
            }

            if (isValid && isValidBaseValidator)
            {
                return true;
            }

            return false;
        }
    }
}
