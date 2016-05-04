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

    public class Dreadnought : BaseStarship
    {
        private const int DefaultDreadnoughtHealth = 200;
        private const int DefaultDreadnoughtShields = 300;
        private const int DefaultDreadnoughtDamage = 150;
        private const int DefaultDreadnoughtFuel = 700;

        public Dreadnought(string starshipName, StarSystem location)
            : base(starshipName, DefaultDreadnoughtHealth, DefaultDreadnoughtShields, DefaultDreadnoughtDamage, DefaultDreadnoughtFuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            var projectile = new Laser(this.Damage + (this.Shields / 2));

            return projectile;
        }

        public override void RespondToAttack(IProjectile attack)
        {
            this.Shields += 50;
            base.RespondToAttack(attack);
            this.Shields -= 50;
        }
    }
}
