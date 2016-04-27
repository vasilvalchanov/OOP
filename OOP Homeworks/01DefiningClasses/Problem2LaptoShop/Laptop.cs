using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LaptoShop
{
    public class Laptop
    {
        private string model;

        private string manufacturer;

        private string processor;

        private int ram;

        private string graphicsCard;

        private string hdd;

        private string screen;

        private Battery battery;

        private decimal price;

        public Laptop(
            string model,
            string manufacturer,
            string processor,
            int ram,
            string graphicsCard,
            string hdd,
            string screen,
            Battery battery,
            decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.Price = price;
        }

        public Laptop(string model, decimal price)
            : this(model, null, null, 0, null, null, null, null, price)
        {
        }

        public Laptop(string model, string manufacturer, int ram, Battery battery, decimal price)
            : this(model, manufacturer, null, ram, null, null, null, battery, price)
        {  
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The model cannot be null");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("The manufacturer cannot be empty");
                }

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("The processor cannot be empty");
                }

                this.processor = value;
            }
        }

        public int Ram
        {
            get
            {
                return this.ram;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The ram cannot be less than 0");
                }

                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("The graphics card cannot be empty");
                }

                this.graphicsCard = value;
            }
        }

        public string HDD
        {
            get
            {
                return this.hdd;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("The hdd cannot be empty");
                }

                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("The screen cannot be empty");
                }

                this.screen = value;
            }
        }

        public Battery Battery { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The price cannot be negavite number");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Model: {0}", this.Model);
            sb.AppendLine();

            if (this.Manufacturer != null)
            {
                sb.AppendFormat("Manufacturer: {0}", this.Manufacturer);
                sb.AppendLine();
            }

            if (this.Processor != null)
            {
                sb.AppendFormat("Processor: {0}", this.Processor);
                sb.AppendLine();
            }

            if (this.Ram != 0)
            {
                sb.AppendFormat("RAM: {0} GB", this.Ram);
                sb.AppendLine();
            }

            if (this.GraphicsCard != null)
            {
                sb.AppendFormat("GraphicsCard: {0}", this.GraphicsCard);
                sb.AppendLine();
            }

            if (this.HDD != null)
            {
                sb.AppendFormat("HDD: {0}", this.HDD);
                sb.AppendLine();
            }

            if (this.Screen != null)
            {
                sb.AppendFormat("Screen: {0}", this.Screen);
                sb.AppendLine();
            }

            if (this.Battery != null)
            {
                sb.AppendFormat("Battery: {0}", this.Battery);
                sb.AppendLine();
            }

            sb.AppendFormat("Price: {0:F2} lv.", this.Price);

            return sb.ToString();
        }
    }
}
