namespace StrategyPattern;

public class CSVExportService: IExportService
{
    public void Export(Order order)
    {
        System.Console.WriteLine($"Exporting {order.Name} to CSV");
    }
}