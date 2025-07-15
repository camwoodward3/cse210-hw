using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string get_name()
    {
        return _name;
    }

    public Address get_address()
    {
        return _address;
    }

    public bool InUSA()
    {
        return true;
    }
}