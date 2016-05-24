using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    using CustomerService.Models;

    public interface ICustomerVisitor
    {
        void Visit(Customer customer);
    }
}
