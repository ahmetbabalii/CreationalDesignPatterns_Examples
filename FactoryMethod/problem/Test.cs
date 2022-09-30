using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.problem
{
    internal class Test
    {
        public static void MainTest(string[] args)
        {
            CarShop cr = new CarShop();
            cr.addNewCar("GOLF", "MiddleClass", 281538, false, false);

            List<Car> cars = cr.getCars();

            foreach (var car in cars)
            {
                car.printInfo();
            }
        }
    }
}
