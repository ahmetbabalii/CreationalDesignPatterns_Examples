

namespace FactoryMethod.solution1
{
    internal class LuxuryFactoryImpl : ILuxuryFactory
    {
        public Luxury create(string model, double netPrice, bool doCarHaveAutoPilot)
        {
            return new Luxury(model, netPrice, doCarHaveAutoPilot);
        }
    }
}
