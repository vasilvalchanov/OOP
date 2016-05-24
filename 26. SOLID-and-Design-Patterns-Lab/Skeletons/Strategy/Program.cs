namespace SharpCompiler
{
    using System;
    using System.IO;

    using SharpCompiler.Exceptions;

    using Strategy.Interfaces;
    using Strategy.Validators;

    public class Program
    {
        private const string ProgramPath = "../../CSharpProgram.cs";
        private const string EntryClassName = "Strategy.Program";

        static void Main()
        {
            try
            {
                string code = File.ReadAllText(ProgramPath);

                ICodeValidationStrategy strategy = new CodeLenghtValidator();
                strategy = new SystemNetValidator();
                var compiler = new CSharpCompiler(strategy);
                compiler.Compile(code);
                compiler.Execute(EntryClassName);
            }
            catch (CompilationException ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
