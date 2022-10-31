using Prototype.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.solution1
{
    internal class Test
    {
        public static void Run()
        {
            IndividualCustomer prototype = new IndividualCustomer(1, "123 Main St", "555-555-5555", true, true, DateTime.Now, "John", "Smith");
            
            IndividualCustomer individualCustomer1 = (IndividualCustomer)prototype.Clone();
            Console.WriteLine(individualCustomer1.ToString());
            
            IndividualCustomer individualCustomer2 = (IndividualCustomer)prototype.Clone();
            individualCustomer2.firstName = "Ahmet";
            individualCustomer2.lastName = "Babalı";
            Console.WriteLine(individualCustomer2.ToString());
        }
    }
}
