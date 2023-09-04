namespace FactoryMethod;

public class DiscountCoutryService : DiscountService
{
    private readonly string CountryCode;
    public DiscountCoutryService(string CountryCode)
    {
        this.CountryCode = CountryCode;
    }

    public override decimal DiscountPercentage
    {
        get {  
            return this.CountryCode switch  
            {
                "BD" => 20.0M,
                "AUS" => 15.0M,
                _ => 5.0M,
            };
        }
    }
    
}