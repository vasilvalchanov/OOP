using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    using TankManufacturer.Units;

    public abstract class TankFactory
    {
        protected TankFactory()
        {          
        }

        public abstract Tank CreateTank();

    }
}
