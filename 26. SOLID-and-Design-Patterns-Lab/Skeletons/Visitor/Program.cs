namespace CustomerService
{
    using System;

    using CustomerService.Data;
    using CustomerService.Models;

    using Visitor.Models.Visitors;

    public class Program
    {
        static void Main()
        {
            var repository = new CustomerRepository();

            var freePurchaseVisitor = new FreePurchaseVisitor();
            var discountRaseVisitor = new DiscountRaseVisitor();
            var premiumCustomers = repository.GetPremiumCustomers();
            foreach (var premiumCustomer in premiumCustomers)
            {
                premiumCustomer.AcceptVisitor(discountRaseVisitor);
            }

            var allCustomers = repository.GetAll();
            foreach (var customer in allCustomers)
            {
                customer.AcceptVisitor(freePurchaseVisitor);
            }

            foreach (var customer in allCustomers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
