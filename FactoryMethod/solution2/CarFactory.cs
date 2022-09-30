using FactoryMethod.solution1;

namespace FactoryMethod.solution2
{
    public class CarFactory
    {
        public Car create(string model, double netPrice, string type)
        {
            Car car = type switch
            {
                "MiddleClass" => new Car(model, netPrice),
                "Luxury" => new Luxury(model, netPrice, true),
                "Premium" => new Premium(model, netPrice, true, true),
                _ => throw new NotImplementedException()
            };
            return car;
        }
    }
}
