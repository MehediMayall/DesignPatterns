namespace AdapterPattern;

public interface ICustomer
{
    List<Customer> GetCustomers();
    void AddCustomer(CustomerDto NewCustomer);
}