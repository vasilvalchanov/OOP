using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Element
    {
        private string type;

        private IList<Element> children; 

        public Element(string type, params Element[] elements)
        {
            this.type = type;
            this.children = new List<Element>(elements);
        }

        public void Add(Element element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("The element cannot be null");
            }

            this.children.Add(element);
        }

        public void Remove(Element element)
        {
            if (!this.children.Contains(element))
            {
                throw new InvalidOperationException("There isn't such element in collection");
            }

            this.children.Remove(element);
        }

        public string Display(int depth)
        {
            var sb = new StringBuilder();

            sb.AppendFormat("{0}<{1}>", new string(' ', depth), this.type);
            sb.AppendLine();

            if (this.children.Count > 0)
            {
                foreach (var element in this.children)
                {
                    sb.Append(element.Display(depth + 2));
                }
            }

            sb.AppendFormat("{0}</{1}>", new string(' ', depth), this.type);
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
