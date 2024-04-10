using Microsoft.Extensions.DependencyInjection;
using FacadePattern;


var serviceProvider = new ServiceCollection()
    .AddSingleton<IProductService, ProductService>()
    .AddSingleton<IPaymentService, PaymentService>()
    .AddSingleton<IInvoiceService, InvoiceService>()
    .AddSingleton<IOrderService, OrderService>()
    .BuildServiceProvider();


var orderService = serviceProvider.GetService<IOrderService>();

orderService.PlaceOrder();


