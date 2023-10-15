using Builder.car.domain;
using static Builder.car.domain.CarEnums;

namespace Builder.car.solution2;

public interface ICarBuilder
{
    ICarBuilder SetBrand(Brand brand);
    ICarBuilder SetModel(Model model);
    ICarBuilder SetColor(Color color);
    ICarBuilder SetTransmission(Transmission transmission);
    ICarBuilder AddExtra(Extra extra);
    ICarBuilder SetFuelType(FuelType fuelType);
    Car Build();
}
