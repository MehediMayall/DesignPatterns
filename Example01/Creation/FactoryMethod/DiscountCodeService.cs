namespace FactoryMethod;

public class DiscountCodeService: DiscountService
{
    private readonly Guid code;
    public DiscountCodeService(Guid code)
    {
        this.code = code;
    }

    public override decimal DiscountPercentage
    {
        get {
            return 5.0M;
        }
    }
}