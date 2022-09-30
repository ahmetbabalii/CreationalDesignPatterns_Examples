
namespace FactoryMethod.solution1
{
    public class Car
    {
        private string model; 
        private int year;
        private double netPrice;

        public Car(string model, double netPrice)
        {
            this.year = DateTime.Now.Year;
            this.model = model;
            this.netPrice = netPrice;
        }

        public void testDriveCar()
        {
            Console.WriteLine("Tüm gün test yapılabilir");
        }

        public double calculateSalePrice()
        {
            double netPrice = getNetPrice();
            double otvPrice = netPrice * 0.8;
            double kdvPrice = (netPrice + otvPrice) * 0.18;
            double total = netPrice + otvPrice + kdvPrice;
            return total;
        }

        public string getModel()
        {
            return model;
        }

        public int getModelYear()
        {
            return year;
        }

        public double getNetPrice()
        {
            return netPrice;
        }

        public virtual void printInfo()
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
