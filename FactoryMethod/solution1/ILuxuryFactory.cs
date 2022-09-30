namespace FactoryMethod.solution1
{
    public interface ILuxuryFactory
    {
        Luxury create(string model, double netPrice, bool doCarHaveAutoPilot);
    }
}
