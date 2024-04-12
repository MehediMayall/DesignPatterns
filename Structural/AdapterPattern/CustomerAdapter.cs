namespace AdapterPattern;

public class CustomerAdapter: ICustomer
{
    private List<Customer> customerList = new List<Customer>();

    public List<Customer> GetCustomers()
    {
        return customerList;
    }

    public void AddCustomer (CustomerDto NewCustomer)
    {
        customerList.Add(new Customer
        {
            Id = NewCustomer.CustomerId,
            CustomerName = NewCustomer.FirstName + " " + NewCustomer.LastName,
            Address = NewCustomer.Address,
            ZipCode = NewCustomer.PostalCode,
            State = NewCustomer.State,
        });
    }
}