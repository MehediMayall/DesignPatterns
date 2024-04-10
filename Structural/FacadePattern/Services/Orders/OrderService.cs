namespace FacadePattern;

public class OrderService: IOrderService
{
    private readonly IProductService product;
    private readonly IPaymentService payment;
    private readonly IInvoiceService invoice;

    public OrderService(IProductService product, IPaymentService payment, IInvoiceService invoice)
    {
        this.product = product;
        this.payment = payment;
        this.invoice = invoice;
    }

    public void PlaceOrder()
    {
        product.GetProductDetails();
        payment.MakePayment();
        invoice.SendInvoice();
    }

}