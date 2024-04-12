namespace StrategyPattern;

public class Order
{
    public string CustomerName { get; set; }
    public string Name { get; set; }
    public int Amount { get; set; }
    public string Description { get; set; }


    public Order(string customerName, string name, int amount)
    {
        CustomerName = customerName;
        Name = name;
        Amount = amount;
    }

    public void Export(IExportService exportService)
    {
        exportService.Export(this);
    }
}