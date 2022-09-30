using FactoryMethod.solution1;

namespace FactoryMethod.solution2
{
    internal class Test
    {
        public static void MainTest(string[] args)
        {
            CarShop cr = new CarShop();         
            CarFactory carFactory = new CarFactory();
         
            cr.addNewCar(carFactory.create("GOLF", 281538, "MiddleClass"));
            cr.addNewCar(carFactory.create("Passat", 639205, "Luxury"));
            cr.addNewCar(carFactory.create("Touareg", 1133364, "Premium"));

            List<Car> cars = cr.getCars();

            foreach (var car in cars)
            {
                car.printInfo();
            }

            Console.ReadKey();
        }
    }
}
