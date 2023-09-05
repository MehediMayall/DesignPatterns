namespace AbstractFactory;

public class CarFactory
{
    public static Car BuildCar(Locations Location, CarTypes CarType)
    {
        return Location switch
        {
            Locations.CHINA => CarFactoryChina.BuildCar(CarType),
            Locations.INDIA =>  CarFactoryIndia.BuildCar(CarType),
            Locations.GERMANY => CarFactoryGermany.BuildCar(CarType),
        };
    }
}