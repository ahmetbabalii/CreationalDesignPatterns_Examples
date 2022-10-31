using Prototype.domain;

namespace Prototype.solution2
{
    public class CorporateCustomerFactory : Factory
    {
        private static CorparateCustomer corparateCustomerProtoType = new(2, "123 Main St", "555-555-5555", true, true, DateTime.Now, "ABC Corp", "John Doe");     

        public Customer create()
        {
            return corparateCustomerProtoType.Clone() as CorparateCustomer;
        }       
    }
}
