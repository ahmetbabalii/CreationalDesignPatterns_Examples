namespace FactoryMethod.problem
{
    public class CarShop
    {
        private List<Car> cars = new List<Car>();

        public CarShop()
        {
            Car normal = new Car("POLO", "MiddleClass", 229796);
            cars.Add(normal);

            Car luxury = new Car("Passat", "Luxury", 639205, true);
            cars.Add(luxury);

            Car premium = new Car("Touareg", "Premium", 1133364, true, true);
            cars.Add(premium);
        }

        public List<Car> getCars()
        {
            return cars;
        }

        public int getAllCarsCount()
        {
            return cars.Count;
        }

        public void addNewCar(string model, string type, double netPrice,
            bool doCarHaveAutoPilot, bool doCarsHaveMassageSeats)
        {
            Car car;
            switch (type)
            {
                case "MiddleClass":
                    car = new Car(model, type, netPrice);
                    cars.Add(car);
                    break;
                case "Luxury":
                    car = new Car(model, type, netPrice, doCarHaveAutoPilot);
                    cars.Add(car);
                    break;
                case "Premium":
                    car = new Car(model, type, netPrice, doCarHaveAutoPilot, doCarsHaveMassageSeats);
                    cars.Add(car);
                    break;
            }
        }
    }
}
