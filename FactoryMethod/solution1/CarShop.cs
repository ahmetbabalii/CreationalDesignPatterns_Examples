
namespace FactoryMethod.solution1
{
    public class CarShop
    {
        private List<Car> cars = new List<Car>();
        public CarShop(){}

        public List<Car> getCars()
        {
            return cars;
        }

        public int getAllCarsCount()
        {
            return cars.Count;
        }

        public void addNewCar(Car car)
        {
            cars.Add(car);
        }

        public void printInfo()
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
