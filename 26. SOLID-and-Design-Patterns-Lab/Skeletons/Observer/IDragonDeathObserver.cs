using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    using Skyrim.Items;

    public interface IDragonDeathObserver
    {
        void Update(Weapon weapon);
    }
}
