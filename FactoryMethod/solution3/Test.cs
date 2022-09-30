using FactoryMethod.solution1;

namespace FactoryMethod.solution3
{
    internal class Test
    {
        public static void MainTest(string[] args)
        {
            CarShop cr = new CarShop();
            CarFactory carFactory = new CarFactory();
           
            cr.addNewCar(carFactory.createCar("GOLF", 281538));
            cr.addNewCar(carFactory.createLuxry("Passat", 639205, true));
            cr.addNewCar(carFactory.createPremium("Touareg", 1133364, true, true));

            List<Car> cars = cr.getCars();

            foreach (var car in cars)
            {
                car.printInfo();
            }

            Console.ReadKey();
        }
    }
}
