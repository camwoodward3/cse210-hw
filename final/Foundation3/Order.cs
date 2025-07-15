using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public float get_TotalPrice()
    {

    }

    public string get_PackingLabel()
    {

    }

    public string get_ShippingLabel()
    {
        if (InUSA)
        {
            shipping_price = $5;
        }
        else {
            shipping_price = 35;
        }
    }
}