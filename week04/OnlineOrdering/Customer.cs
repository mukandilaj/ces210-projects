using System;

public class Customer
{
    // Member variables
    private string _customerName;
    private Address _address;

    // Constructor
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    // Methods
    public bool IsCustomerInUsa()
    {
        return _address.IsAddressInUsa();
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetCustomerAddress()
    {
        return _address;
    }
}