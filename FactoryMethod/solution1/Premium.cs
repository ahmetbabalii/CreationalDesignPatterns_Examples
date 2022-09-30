
namespace FactoryMethod.solution1
{
    public class Premium : Luxury
    {
        private bool doCarsHaveMassageSeats;
        public Premium(string model, double netPrice, bool doCarHaveAutoPilot, bool doCarsHaveMassageSeats)
            : base(model, netPrice, doCarHaveAutoPilot)
        {
            this.doCarsHaveMassageSeats = doCarsHaveMassageSeats;
        }

        public new void testDriveCar()
        {
            Console.WriteLine("Premium araçlarda test sürüşü deneyim yılınıza göre karar verilir.");
            autoPilotTest();
            autoMassageSeatsTest();
        }

        public void autoMassageSeatsTest()
        {
            if(messageSeatsControl())
                Console.WriteLine("Araç içi masaj koltuklarına test yapılabilir");
        }

        public new double calculateSalePrice()
        {
            double netPrice = getNetPrice();
            double otvPrice = netPrice * 2.2;
            double kdvPrice = (netPrice + otvPrice) * 0.18;
            double total = netPrice + otvPrice + kdvPrice;
            return total;
        }
        
        public bool messageSeatsControl()
        {
            return doCarsHaveMassageSeats;
        }

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
