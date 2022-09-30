namespace FactoryMethod.solution1
{
    public interface ICarFactory
    {
        Car create(string model, double netPrice);
    }
}
