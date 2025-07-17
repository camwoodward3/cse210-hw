using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public string CreateShippingLabel()
    {
        return $"{_customer.get_name()} - {_customer.get_address()}";
    }

    public void CreatePackingLabel()
    {

        foreach (Product product in _products)
        {
            Console.WriteLine($"{_customer.get_name()} - {product.get_fullProduct()}");
        }
    }


    public double GetShippingCost()
    {
        if (_customer.InUSA() == true)
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }

    public double get_TotalPrice()
    {
        double cost = 0.0;
        foreach (Product product in _products)
        {
            cost += product.get_TotalCost();
        }
        cost += GetShippingCost();
        return cost;

    }


}