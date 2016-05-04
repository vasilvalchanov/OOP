using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Ships
{
    using MassEffect.GameObjects.Enhancements;
    using MassEffect.GameObjects.Locations;
    using MassEffect.Interfaces;

    public abstract class BaseStarship : IStarship
    {
        private IList<Enhancement> enhancements;

        private int health;

        private int shields;

        protected BaseStarship(string starshipName, int health, int shields, int damage, double fuel, StarSystem location)
        {

            this.Name = starshipName;
            this.Health = health;
            this.Shields = shields;
            this.Damage = damage;
            this.Fuel = fuel;
            this.Location = location;
            this.enhancements = new List<Enhancement>();
        }

        public string Name { get; set; }

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this.health = value;
            }
        }

        public int Shields
        {
            get
            {
                return this.shields;
            }

            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this.shields = value;
            }
        }

        public int Damage { get; set; }

        public double Fuel { get; set; }

        public StarSystem Location { get; set; }

        public IEnumerable<Enhancement> Enhancements
        {
            get
            {
                return this.enhancements;
            }
        }

        public abstract IProjectile ProduceAttack();


        public virtual void RespondToAttack(IProjectile attack)
        {
            attack.Hit(this);
        }
        

        public void AddEnhancement(Enhancement enhancement)
        {
            if (enhancement == null)
            {
                throw new ArgumentNullException("Enhancement cannot be null");
            }

            this.enhancements.Add(enhancement);

            this.Damage += enhancement.DamageBonus;
            this.Shields += enhancement.ShieldBonus;
            this.Fuel += enhancement.FuelBonus;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("--{0} - {1}", this.Name, this.GetType().Name);
            sb.AppendLine();

            if (this.Health <= 0)
            {
                sb.Append("(Destroyed)");
            }
            else
            {
                sb.AppendFormat("-Location: {0}", this.Location.Name);
                sb.AppendLine();
                sb.AppendFormat("-Health: {0}", this.Health);
                sb.AppendLine();
                sb.AppendFormat("-Shields: {0}", this.Shields);
                sb.AppendLine();
                sb.AppendFormat("-Damage: {0}", this.Damage);
                sb.AppendLine();
                sb.AppendFormat("-Fuel: {0:F1}", this.Fuel);
                sb.AppendLine();
                sb.AppendFormat("-Enhancements: {0}", !this.Enhancements.Any() ? "N/A" : string.Join(", ", this.Enhancements));
                
            }

            return sb.ToString();

        }
    }
}
