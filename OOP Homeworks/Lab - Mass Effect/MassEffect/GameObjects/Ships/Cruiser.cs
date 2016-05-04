using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Ships
{
    using MassEffect.GameObjects.Locations;
    using MassEffect.GameObjects.Projectiles;
    using MassEffect.Interfaces;

    public class Cruiser : BaseStarship
    {
        private const int DefaultCruiserHealth = 100;
        private const int DefaultCruiserShields = 100;
        private const int DefaultCruiserDamage = 50;
        private const int DefaultCruiserFuel = 300;

        public Cruiser(string starshipName, StarSystem location)
            : base(starshipName, DefaultCruiserHealth, DefaultCruiserShields, DefaultCruiserDamage, DefaultCruiserFuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            var projectile = new PenetrationShell(this.Damage);

            return projectile;
        }

    }
}
