

namespace FactoryMethod.solution1
{
    internal class Test
    {        
        public static void MainTest(string[] args)
        {
            CarShop cr = new CarShop();
            ICarFactory carFactory = new CarFactoryImpl();
            ILuxuryFactory luxuryFactory = new LuxuryFactoryImpl();
            IPremiumFactory premiumFactory = new PremiumFactoryImpl();

            cr.addNewCar(carFactory.create("GOLF", 281538));
            cr.addNewCar(luxuryFactory.create("Passat", 639205, true));
            cr.addNewCar(premiumFactory.create("Touareg", 1133364, true, true));

            List<Car> cars = cr.getCars();  

            foreach (var car in cars)
            {
                car.printInfo();
            }

            Console.ReadKey();
        }
    }
}
