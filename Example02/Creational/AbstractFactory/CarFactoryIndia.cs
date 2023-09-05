namespace AbstractFactory;

public class CarFactoryIndia
{
    public static Car BuildCar(CarTypes CarType)
    {
        return CarType switch
        {
            CarTypes.MICRO => new CarMicro(Locations.INDIA),
            CarTypes.MINI => new CarMini(Locations.INDIA),
            CarTypes.LUXURY => new CarLuxury(Locations.INDIA)
        };
    }
}