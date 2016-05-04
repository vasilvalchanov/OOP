using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Models.Characters
{
    using TheSlum.Interfaces;

    public class Healer : ExtendedCharacter, IHeal
    {
        private const int DefaultHealthPoints = 75;
        private const int DefaultDefensePoints = 50;
        private const int DefaultHealingPoints = 60;
        private const int DefaultRange = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, DefaultHealthPoints, DefaultDefensePoints, team, DefaultRange)
        {
            this.HealingPoints = DefaultHealingPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targets = targetsList.Where(t => t.IsAlive).Where(t => t.Team == this.Team).Where(t => t != this);

            int minHealthPoints = targets.Min(t => t.HealthPoints);
            var target = targets.FirstOrDefault(t => t.HealthPoints == minHealthPoints);

            return target; 
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.HealingPoints += item.HealthEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.HealingPoints -= item.HealthEffect;

        }


        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());
            sb.AppendFormat(" ,Healing: {0}", this.HealingPoints);

            return sb.ToString();
        }
    }
}
