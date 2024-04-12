using StrategyPattern;

var order = new Order("Mehedi Hasan", "Macbook Pro", 5);
order.Export(new JSONExportService());
