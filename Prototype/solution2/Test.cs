using Prototype.domain;

namespace Prototype.solution2
{
    internal class Test
    {
        public static void Run()
        {
            Customer corparateCustomer = new CorporateCustomerFactory().create();
            Customer individualCustomer = new IndividualCustomerFactory().create();

            Console.WriteLine(individualCustomer.ToString());
            Console.WriteLine(corparateCustomer.ToString());
        }
    }
}
