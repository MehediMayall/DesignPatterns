namespace AbstractFactory;

public class CarMini : Car
{
    public CarMini(Locations Location): base(CarTypes.MINI, Location)
    {
        this.Construct();
    }

    public override void Construct()
    {
        print($"Constructing Mini Car in {Location}");
    } 
}