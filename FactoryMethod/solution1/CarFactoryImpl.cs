
namespace FactoryMethod.solution1
{
    internal class CarFactoryImpl : ICarFactory
    {
        public CarFactoryImpl()
        {

        }

        public Car create(string model, double netPrice)
        {
            return new Car(model, netPrice);
        }
    }
}
