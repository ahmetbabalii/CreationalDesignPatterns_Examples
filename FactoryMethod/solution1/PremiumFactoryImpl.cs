
namespace FactoryMethod.solution1
{
    internal class PremiumFactoryImpl : IPremiumFactory
    {
        public Premium create(string model, double netPrice, bool doCarHaveAutoPilot, bool doCarsHaveMassageSeats)
        {
            return new Premium(model, netPrice, doCarHaveAutoPilot, doCarsHaveMassageSeats);
        }
    }
}
