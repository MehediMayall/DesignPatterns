namespace FacadePattern;

public class ProductService : IProductService
{
    public void GetProductDetails()
    {
        System.Console.WriteLine($"Fetching the product details");
    }
}