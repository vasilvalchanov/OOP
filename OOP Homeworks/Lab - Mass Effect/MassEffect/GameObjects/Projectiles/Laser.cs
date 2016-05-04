using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Projectiles
{
    using MassEffect.Interfaces;

    public class Laser : BaseProjectile
    {
        public Laser(int damage)
            : base(damage)
        {
        }

        public override void Hit(IStarship ship)
        {
            int remainderDamage = ship.Shields - this.Damage;

            ship.Shields -= this.Damage;

            if (remainderDamage < 0)
            {
                ship.Health += remainderDamage;
            }
        }
    }
}
