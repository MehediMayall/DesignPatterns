namespace AbstractFactory;

public class CarFactoryGermany
{
    public static Car BuildCar(CarTypes CarType)
    {
        return CarType switch
        {
            CarTypes.MICRO => new CarMicro(Locations.GERMANY),
            CarTypes.MINI => new CarMini(Locations.GERMANY),
            CarTypes.LUXURY => new CarLuxury(Locations.GERMANY)
        };
    }
}