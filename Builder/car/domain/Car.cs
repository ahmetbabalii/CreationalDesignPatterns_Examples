using System.Text;
using static Builder.car.domain.CarEnums;

namespace Builder.car.domain;

public class Car
{
    private Brand CarBrand { get; set; }
    private Model CarModel { get; set; }
    private Color CarColor { get; set; }
    private Transmission CarTransmission { get; set; }
    public List<Extra> CarExtras { get; set; }
    private FuelType CarFuelType { get; set; }

    public Car(){}

    public Car(Brand carBrand) => CarBrand = carBrand;

    public Car(Brand carBrand, Model carModel)
    {
        CarBrand = carBrand;
        CarModel = carModel;
    }

    public Car(Brand carBrand, Model carModel, Color carColor)
    {
        CarBrand = carBrand;
        CarModel = carModel;
        CarColor = carColor;
    }

    public Car(Brand carBrand, Model carModel, Color carColor, Transmission carTransmission)
    {
        CarBrand = carBrand;
        CarModel = carModel;
        CarColor = carColor;
        CarTransmission = carTransmission;
    }

    public Car(Brand carBrand, Model carModel, Color carColor, Transmission carTransmission, List<Extra> carExtras)
    {
        CarBrand = carBrand;
        CarModel = carModel;
        CarColor = carColor;
        CarTransmission = carTransmission;
        CarExtras = carExtras;
    }

    public Car(Brand carBrand, Model carModel, Color carColor, Transmission carTransmission, List<Extra> carExtras, FuelType carFuelType)
    {
        CarBrand = carBrand;
        CarModel = carModel;
        CarColor = carColor;
        CarTransmission = carTransmission;
        CarExtras = carExtras;
        CarFuelType = carFuelType;
    }

    public string GetInfo()
    {
        StringBuilder info = new();
        info.AppendLine($"Brand: {CarBrand}");
        info.AppendLine($"Model: {CarModel}");
        info.AppendLine($"Color: {CarColor}");
        info.AppendLine($"Transmission: {CarTransmission}");
        info.AppendLine($"Fuel Type: {CarFuelType}");

        if (CarExtras != null && CarExtras.Count > 0)
        {
            info.AppendLine("Extras:");
            foreach (var extra in CarExtras)
            {
                info.AppendLine($"- {extra}");
            }
        }

        return info.ToString();
    }

    public void SetCarBrand(Brand brand) => CarBrand = brand;
    public void SetCarModel(Model model) => CarModel = model;
    public void SetCarColor(Color color) => CarColor = color;
    public void SetCarTransmission(Transmission transmission) => CarTransmission = transmission;
    public void SetCarFuelType(FuelType fuelType) => CarFuelType = fuelType;
}
