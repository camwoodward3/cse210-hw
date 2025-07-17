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

    public string get_address()
    {
        return _address.Get_fullAdd();
    }

    public bool InUSA()
    {
        return _address.InUSA();
    }
}