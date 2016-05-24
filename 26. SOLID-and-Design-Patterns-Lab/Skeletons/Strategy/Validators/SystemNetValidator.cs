using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Validators
{
    using SharpCompiler.Exceptions;

    using Strategy.Interfaces;

    public class SystemNetValidator : ICodeValidationStrategy
    {
        public void Validate(string codeString)
        {
            if (!codeString.Contains("using System.Net"))
            {
                throw new CompilationException("Missing reference \"System.Net\"");
            }
        }
    }
}
