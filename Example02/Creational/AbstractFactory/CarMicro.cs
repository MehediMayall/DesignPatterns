namespace AbstractFactory;

public class CarMicro : Car
{
    public CarMicro(Locations Location) : base(CarTypes.MICRO, Location)
    {
        this.Construct();
    }

    public override void Construct()
    {
        print($"Constructing Micro Car in {Location}");
    }
}