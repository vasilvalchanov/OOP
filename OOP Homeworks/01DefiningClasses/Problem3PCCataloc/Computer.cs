using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3PCCataloc
{
    public class Computer
    {
        private string name;

        private IList<Component> components;

        private decimal price;


        public Computer(string name, IList<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be null");
                }

                this.name = value;
            }
        }

        public IList<Component> Components
        {
            get
            {
                return this.components;
            }

            set
            {
                if (value.Count() == 0)
                {
                    throw new ArgumentException("The computer should have at least one component");
                }

                this.components = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.GetTotalPrice();
            }
        }


        private decimal GetTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var component in this.Components)
            {
                totalPrice += component.Price;
            }

            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Name: {0}", this.Name);
            sb.AppendLine();

            foreach (var component in this.Components)
            {
                sb.AppendFormat(component.ToString());
                sb.AppendLine();
            }

            sb.AppendFormat("Total price: {0:C}", this.GetTotalPrice());

            return sb.ToString();
        }
    }
}
