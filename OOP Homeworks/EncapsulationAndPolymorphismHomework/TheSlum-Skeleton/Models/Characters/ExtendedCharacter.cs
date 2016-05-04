using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Models.Characters
{
    public abstract class ExtendedCharacter : Character
    {
        protected ExtendedCharacter(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }
    }
}
