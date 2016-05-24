using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Validators
{
    using SharpCompiler.Exceptions;

    using Strategy.Interfaces;

    public class CodeLenghtValidator : ICodeValidationStrategy
    {
        public void Validate(string code)
        {
            if (code.Length < 20)
            {
                throw new CompilationException("The lenght of code should be at least 20 characters");
            }
        }
    }
}
