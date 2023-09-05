namespace AbstractFactory;

public class CarFactoryChina
{
    public static Car BuildCar(CarTypes CarType)
    {
        return CarType switch
        {
            CarTypes.MICRO => new CarMicro(Locations.CHINA),
            CarTypes.MINI => new CarMini(Locations.CHINA),
            CarTypes.LUXURY => new CarLuxury(Locations.CHINA)
        };
    }
}