using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Projectiles
{
    using MassEffect.Interfaces;

    public abstract class BaseProjectile : IProjectile
    {

        protected BaseProjectile(int damage)
        {
            this.Damage = damage;
        }

        public int Damage { get; set; }

        public abstract void Hit(IStarship ship);

    }
}
