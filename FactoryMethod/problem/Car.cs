namespace FactoryMethod.problem
{
    public class Car
    {
        private string model;
        private string type;
        private double netPrice;

        private bool doCarHaveAutoPilot;
        
        private bool doCarsHaveMassageSeats;

        public Car(string model, string type, double netPrice)
        {
            this.model = model;
            this.type = type;
            this.netPrice = netPrice;
        }

        public Car(string model, string type, double netPrice, bool doCarHaveAutoPilot)
        : this(model, type, netPrice)
        {
            this.doCarHaveAutoPilot = doCarHaveAutoPilot;
        }

        public Car(string model, string type, double netPrice, bool doCarHaveAutoPilot, bool doCarsHaveMassageSeats)
            : this(model, type, netPrice, doCarHaveAutoPilot)
        {
            this.doCarsHaveMassageSeats = doCarsHaveMassageSeats;
        }

        public void testDriveCar()
        {
            switch (type)
            {
                case "MiddleClass":
                    Console.WriteLine("Tüm gün test yapılabilir");
                    break;

                case "Luxury":
                    Console.WriteLine("1 saatlik bir test sürüçü yapılabilir");
                    
                    if (autopilotControl())
                        Console.WriteLine("Araçta oto piloat testti yapılabilir");
                    
                    break;

                case "Premium":
                    Console.WriteLine("Premium araçlarda test sürüşü deneyim yılınıza göre karar verilir");
                    
                    if (autopilotControl())
                        Console.WriteLine("Araçta oto piloat testti yapılabilir");
                    
                    if (messageSeatsControl())
                        Console.WriteLine("Araç içi masaj koltuklarına test yapılabilir");
                    break;
            }
        }

        public double calculateSalePrice()
        {
            double otvPrice;
            double kdvPrice;
            
            switch (type)
            {
                case "MiddleClass":
                default:  // %80
                    otvPrice = netPrice * 0.8;
                    break;

                case "Luxury":  // %150
                    otvPrice = netPrice * 1.5;
                    break;

                case "Premium": // %220
                    otvPrice = netPrice * 2.2;
                    break;
            }

            kdvPrice = (netPrice + otvPrice) * 0.18;
            double total = netPrice + otvPrice + kdvPrice;
            return total;
        }

        public string getModel()
        {
            return model;
        }

        public string getModelType()
        {
            return type;
        }

        public bool autopilotControl()
        {
            return doCarHaveAutoPilot;
        }

        public bool messageSeatsControl()
        {
            return doCarsHaveMassageSeats;
        }

        public void printInfo()
        {
            Console.WriteLine("Araç Bilgileri:");
            Console.WriteLine("Model: {0}", getModel());
            Console.WriteLine("ModelType: {0}", getModelType());
            Console.WriteLine("NetPrice: {0}", netPrice.ToString("N2"));
            Console.WriteLine("SalePrice: {0}", calculateSalePrice().ToString("N2"));
            Console.WriteLine("AutoPilot Desteği: {0}", autopilotControl() ? "var" : "yok");
            Console.WriteLine("Masajlı Koltuk Desteği: {0}", messageSeatsControl() ? "var" : "yok");
            testDriveCar();
            Console.WriteLine("");
        }
    }
}
