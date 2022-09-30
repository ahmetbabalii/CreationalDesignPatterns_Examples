using FactoryMethod.solution1;

namespace FactoryMethod.solution3
{
    internal class CarFactory
    {
        public Car createCar(string model, double netPrice)
        {
            Car car = new Car(model, netPrice);
            return car;
        }

        public Luxury createLuxry(string model, double netPrice, bool doCarHaveAutoPilot)
        {
            Luxury car = new Luxury(model, netPrice, doCarHaveAutoPilot);
            return car;
        }

        public Premium createPremium(string model, double netPrice, bool doCarHaveAutoPilot, bool doCarsHaveMassageSeats)
        {
            Premium car = new Premium(model, netPrice, doCarHaveAutoPilot, doCarsHaveMassageSeats);
            return car;
        }
    }
}
