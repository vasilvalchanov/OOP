using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LaptoShop
{
    public class Battery
    {
        private string batteryType;

        private double batteryLifeInHours;

        public Battery(string batteryType, double batteryLife)
        {
            this.BatteryType = batteryType;
            this.BatteryLifeInHours = batteryLife;
        }

        public string BatteryType
        {
            get
            {
                return this.batteryType;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                   throw new ArgumentNullException("Battery type cannot be null");
                }

                this.batteryType = value;
            }
        }

        public double BatteryLifeInHours
        {
            get
            {
                return this.batteryLifeInHours;
            }

            set
            {
                if (value < 0)
                {
                   throw new ArgumentOutOfRangeException("Battery life cannot be negative number");
                }

                this.batteryLifeInHours = value;

            }
        }

        public override string ToString()
        {
            return string.Format(
                "{3}--Battery type: {0}{1}--Battery Life in hours: {2} hours",
                this.BatteryType,
                Environment.NewLine,
                this.BatteryLifeInHours,
                Environment.NewLine);
        }
    }
}
