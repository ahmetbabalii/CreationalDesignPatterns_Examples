using Prototype.domain;

namespace Prototype.problem
{
    public class Test
    {
        public static void Run()
        {
            IndividualCustomer individualCustomer = new IndividualCustomer(1, "123 Main St", "555-555-5555", true, true, DateTime.Now, "John", "Smith");                           
            CorparateCustomer corparateCustomer = new CorparateCustomer(2, "123 Main St", "555-555-5555", true, true, DateTime.Now, "ABC Corp", "John Doe");        

            Console.WriteLine(individualCustomer.ToString());
            Console.WriteLine(corparateCustomer.ToString());
        }
    }
}
