namespace _9.Decorator
{
    using System;

    using _9.Decorator.Decorators;

    public class DecoratorMain
    {
        private static void Main()
        {
            var decorator = new ExtendedDecorator(new SimpleValidator(), new AlphanumericValidator(), new LenghtValidator(1, 10));

             var hasValidationSuccessful = decorator.Validate("a99a666");

            Console.WriteLine(hasValidationSuccessful);
        }
    }
}
