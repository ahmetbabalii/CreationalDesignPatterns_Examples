using static Builder.car.domain.CarEnums;

namespace Builder.car.solution2
{
    public class Test
    {
        public static void MainTest()
        {
            var car = new CarBuilder()
                .SetBrand(Brand.Toyota)
                .SetModel(Model.Corolla)
                .SetColor(Color.Blue)
                .SetTransmission(Transmission.Automatic)
                .AddExtra(Extra.GPS)
                .AddExtra(Extra.Sunroof)
                .SetFuelType(FuelType.Electric)
                .Build();

            string carInfo = car.GetInfo();
            Console.WriteLine(carInfo);            
        }
    }
}
