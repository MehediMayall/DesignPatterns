namespace AbstractFactory;


public abstract class Car
{
    private CarTypes carType;
    private Locations location;

    public Car(CarTypes CarType, Locations Location)
    {
        this.carType = CarType;
        this.location = Location;
    }

    public CarTypes CarType
    {
        get { return carType; }
        set { carType = value; }
    }

    public Locations Location
    {
        get { return location; }
        set { location = value; }
    }

    public abstract void Construct();

    public override string ToString() => $"Car Type: {carType}, Factory Location: {location}";
    public void print(object Message) => Console.WriteLine(Message);
}