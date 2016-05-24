namespace Skyrim.Units
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Observer;

    using Skyrim.Items;

    public class Warrior : Unit, IDragonDeathObserver
    {
        public Warrior(string name, int attackPoints, int healthPoints) 
            : base(name, attackPoints, healthPoints)
        {
            this.Inventory = new List<Weapon>();
        }

        public IList<Weapon> Inventory { get; private set; }

        public void Update(Weapon weapon)
        {
            this.Inventory.Add(weapon);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat(
                "{0} --> AttackPoints: {1}, HealthPoints: {2}",
                this.Name,
                this.AttackPoints,
                this.HealthPoints);
            sb.AppendLine();
            sb.AppendFormat("{0}", string.Join(Environment.NewLine, this.Inventory));
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
