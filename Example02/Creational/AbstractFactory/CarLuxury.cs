namespace AbstractFactory;

public class CarLuxury: Car
{
    public CarLuxury(Locations Location) : base(CarTypes.LUXURY, Location)
    {
        this.Construct();
    }

    public override void Construct()
    {
        print($"Constructing Luxury Car in {Location}");
    }
}