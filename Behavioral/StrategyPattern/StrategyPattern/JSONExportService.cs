namespace StrategyPattern;

public class JSONExportService : IExportService
{
    public void Export(Order order)
    {
        System.Console.WriteLine($"Exporting {order.Name} to JSON");
    }
}