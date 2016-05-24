using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Models.Visitors
{
    using CustomerService.Models;

    public class DiscountRaseVisitor : ICustomerVisitor
    {
        public void Visit(Customer customer)
        {
            customer.RaiseDiscount(5);
        }
    }
}
