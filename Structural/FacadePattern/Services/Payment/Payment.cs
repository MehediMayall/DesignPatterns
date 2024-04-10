namespace FacadePattern;

public class PaymentService: IPaymentService
{
    public void MakePayment()
    {
        System.Console.WriteLine("Payment completed successfully");
    }
}