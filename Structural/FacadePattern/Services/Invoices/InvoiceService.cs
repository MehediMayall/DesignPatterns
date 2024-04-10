namespace FacadePattern;

public class InvoiceService : IInvoiceService
{
    public void SendInvoice()
    {
        System.Console.WriteLine("Invoice sent successfully");
    }
}