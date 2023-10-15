using Builder.car.domain;
using static Builder.car.domain.CarEnums;

namespace Builder.car.solution1;
public class Test
{
    public static void MainTest()
    {          
        var car = new Car();
        car.SetCarBrand(Brand.Toyota);
        car.SetCarModel(Model.Corolla);
        car.SetCarColor(Color.Blue);
        car.SetCarTransmission(Transmission.Automatic);
        car.SetCarFuelType(FuelType.Electric);

        // OR

        var car2 = new Car(Brand.Toyota, Model.Corolla, Color.Blue, Transmission.Automatic);

        string carInfo = car.GetInfo();
        string car2Info = car2.GetInfo();
        Console.WriteLine(carInfo);
        Console.WriteLine(car2Info);
    }
}

