using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Models.Items.ItemsWithTemporaryEffect
{
    public class Pill : Bonus
    {
        private const int PillHealthEffect = 0;
        private const int PillDefenseEffect = 0;
        private const int PillAttackEffect = 100;
        private const int TimeOutEffect = 1;

        public Pill(string id)
            : base(id, PillHealthEffect, PillDefenseEffect, PillAttackEffect)
        {
            this.Countdown = TimeOutEffect;
        }

    }
}
