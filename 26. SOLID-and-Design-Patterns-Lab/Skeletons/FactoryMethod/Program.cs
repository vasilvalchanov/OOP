namespace TankManufacturer
{
    using System;

    using FactoryMethod.Factories;

    using TankManufacturer.Units;

    class Program
    {
        static void Main()
        {


            TankFactory tankFactory = new GermanTankFactory();
            var germanTank = tankFactory.CreateTank();
            Console.WriteLine(germanTank);

            tankFactory = new AmericanTankFactory();
            var americanTank = tankFactory.CreateTank();
            Console.WriteLine(americanTank);

            tankFactory = new RussianTankFactory();
            var russianTank = tankFactory.CreateTank();
            Console.WriteLine(russianTank);
        }
    }
}
