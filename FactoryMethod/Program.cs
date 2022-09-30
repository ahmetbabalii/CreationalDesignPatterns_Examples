using FactoryMethod;
using System.Data;
using System.Data.Common;
using problem = FactoryMethod.problem;
using solution1 = FactoryMethod.solution1;
using solution2 = FactoryMethod.solution2;
using solution3 = FactoryMethod.solution3;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // problem.Test.MainTest(args);
            // solution1.Test.MainTest(args);
            // solution2.Test.MainTest(args);
            solution3.Test.MainTest(args);

            DataTable table = DbProviderFactories.GetFactoryClasses();
        }
    }
}