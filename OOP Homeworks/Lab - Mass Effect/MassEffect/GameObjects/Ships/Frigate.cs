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

    public class Frigate : BaseStarship
    {
        private const int DefaultFrigatetHealth = 60;
        private const int DefaultFrigateShields = 50;
        private const int DefaultFrigateDamage = 30;
        private const int DefaultFrigateFuel = 220;

        private int projectilesFired;

        public Frigate(string starshipName, StarSystem location)
            : base(starshipName, DefaultFrigatetHealth, DefaultFrigateShields, DefaultFrigateDamage, DefaultFrigateFuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            this.projectilesFired++;
            var projectile = new ShieldReaver(this.Damage);

            return projectile;
        }

        public override string ToString()
        {
            if (this.Health > 0)
            {
                var sb = new StringBuilder(base.ToString());
                sb.AppendLine();
                sb.AppendFormat("-Projectiles fired: {0}", this.projectilesFired);

                return sb.ToString();
            }
            return base.ToString();
        }
    }
}
