using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    using TankManufacturer.Units;

    public class GermanTankFactory : TankFactory
    {
        public override Tank CreateTank()
        {
           return new Tank("Tiger", 4.5, 120);
        }
    }
}
