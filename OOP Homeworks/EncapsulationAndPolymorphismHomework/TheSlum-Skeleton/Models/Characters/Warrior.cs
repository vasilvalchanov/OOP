using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Models.Characters
{
    using TheSlum.Interfaces;

    public class Warrior : ExtendedCharacter, IAttack
    {
        private const int DefaultHealthPoints = 200;
        private const int DefaultDefensePoints = 100;
        private const int DefaultAttackPoints = 150;
        private const int DefaultRange = 2;

        public Warrior(string id, int x, int y, Team team)
            : base(id, x, y, DefaultHealthPoints, DefaultDefensePoints, team, DefaultRange)
        {
            this.AttackPoints = DefaultAttackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            
            var target =
                targetsList.FirstOrDefault(
                    t => t.IsAlive && t.Team != this.Team);

            return target;

        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;

        }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());
            sb.AppendFormat(" ,Attack: {0}", this.AttackPoints);

            return sb.ToString();
        }
    }
}
