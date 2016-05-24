namespace Skyrim.Units
{
    using System;
    using System.Collections.Generic;

    using Skyrim.Items;

    public class Dragon : Unit
    {
        private Dictionary<string, Warrior> warriors;

        private Weapon weaponToDrop;

        public Dragon(string name, int attackPoints, int healthPoints, Weapon weaponToDrop) 
            : base(name, attackPoints, healthPoints)
        {
            this.warriors = new Dictionary<string, Warrior>();
            this.weaponToDrop = weaponToDrop;
        }

        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }

            set
            {
                base.HealthPoints = value;
                if (base.HealthPoints <= 0)
                {
                    this.Notify();
                }
            }
        }

        public void Attach(Warrior warrior)
        {
            if (warrior != null)
            {
                this.warriors.Add(warrior.Name, warrior);
            }   
        }

        public void Detach(Warrior warrior)
        {
            if (!this.warriors.ContainsKey(warrior.Name))
            {
               throw new InvalidOperationException("There isn't  such warrior in the list");
            }

            this.warriors.Remove(warrior.Name);
        }

        private void Notify()
        {
            foreach (var warrior in this.warriors)
            {
                warrior.Value.Update(this.weaponToDrop);
            }
        }


    }
}
