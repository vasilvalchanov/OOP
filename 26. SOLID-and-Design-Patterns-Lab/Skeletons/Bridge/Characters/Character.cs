using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Characters
{
    using Bridge.Weapons;

    public abstract class Character
    {
        private Weapon weapon;

        protected Character(Weapon weapon)
        {
            this.Weapon = weapon;
        }

        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The weapon cannot be null");
                }

                this.weapon = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} wields weapon {1}", this.GetType().Name, this.Weapon);
        }
    }
}
