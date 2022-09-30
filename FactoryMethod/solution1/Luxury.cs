
namespace FactoryMethod.solution1
{
    public class Luxury : Car
    {
        private bool doCarHaveAutoPilot;
        public Luxury(string model, double netPrice, bool doCarHaveAutoPilot) : base(model, netPrice)
        {
            this.doCarHaveAutoPilot = doCarHaveAutoPilot;
        }

        public new void testDriveCar()
        {
            Console.WriteLine("1 saatlik bir test sürüçü yapılabilir.");
            autoPilotTest();
        }

        public void autoPilotTest()
        {
            if (autopilotControl())
                Console.WriteLine("Araçta oto piloat testti yapılabilir");
        }

        public new double calculateSalePrice()
        {
            double netPrice = getNetPrice();
            double otvPrice = netPrice * 1.5;
            double kdvPrice = (netPrice + otvPrice) * 0.18;
            double total = netPrice + otvPrice + kdvPrice;
            return total;
        }

        private bool autopilotControl() => doCarHaveAutoPilot;

        public override void printInfo()
        {
            Console.WriteLine("Araç Bilgileri:");
            Console.WriteLine("Model: {0}", getModel());
            Console.WriteLine("Year: {0}", getModelYear());
            Console.WriteLine("NetPrice: {0}", getNetPrice().ToString("N2"));
            Console.WriteLine("SalePrice: {0}", calculateSalePrice().ToString("N2"));
            testDriveCar();
            Console.WriteLine("");
        }
    }
}
