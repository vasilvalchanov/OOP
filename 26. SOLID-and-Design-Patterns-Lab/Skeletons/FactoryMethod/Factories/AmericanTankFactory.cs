using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    using TankManufacturer.Units;

    public class AmericanTankFactory : TankFactory
    {
        public override Tank CreateTank()
        {
            return new Tank("M1 Abrams", 5.4, 120);
        }
    }
}
