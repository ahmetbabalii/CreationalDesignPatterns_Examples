using Prototype.domain;

namespace Prototype.solution2
{
    public class IndividualCustomerFactory : Factory
    {
        private static IndividualCustomer individualCustomerProtoType = new(1, "123 Main St", "555-555-5555", true, true, DateTime.Now, "John", "Smith");

        public Customer create()
        {
            return individualCustomerProtoType.Clone() as IndividualCustomer;
        }
    }
}
