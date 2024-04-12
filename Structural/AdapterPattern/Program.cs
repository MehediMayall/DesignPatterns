using AdapterPattern;

ICustomer customer = new CustomerAdapter();


CustomerDto newCustomer = new CustomerDto{
    CustomerId = 1,
    FirstName = "Mehedi",
    LastName = "Hasan",
    Address = "Some address",
    State = "Dhaka",
    PostalCode = 1225
};

customer.AddCustomer(newCustomer);

foreach (var item in customer.GetCustomers())
{
    Console.WriteLine($"ID: {item.Id.ToString()}, Customer: {item.CustomerName}, Address: {item.Address}");
}

