using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    using TankManufacturer.Units;

    public class RussianTankFactory : TankFactory
    {
        public override Tank CreateTank()
        {
            return new Tank("T 34", 3.3, 75);
        }
    }
}
