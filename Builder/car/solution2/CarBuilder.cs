
using Builder.car.domain;
using static Builder.car.domain.CarEnums;

namespace Builder.car.solution2;

public class CarBuilder : ICarBuilder
{
    private readonly Car car = new();

    public ICarBuilder SetBrand(Brand brand)
    {
        car.SetCarBrand(brand);
        return this;
    }

    public ICarBuilder SetModel(Model model)
    {
        car.SetCarModel(model);
        return this;
    }

    public ICarBuilder SetColor(Color color)
    {
        car.SetCarColor(color);
        return this;
    }

    public ICarBuilder SetTransmission(Transmission transmission)
    {
        car.SetCarTransmission(transmission);
        return this;
    }

    public ICarBuilder SetFuelType(FuelType fuelType)
    {
        car.SetCarFuelType(fuelType);
        return this;
    }

    public ICarBuilder AddExtra(Extra extra)
    {
        car.CarExtras ??= new List<Extra>();
        car.CarExtras.Add(extra);
        return this;
    }

    public Car Build()
    {
        return car;
    }
}
