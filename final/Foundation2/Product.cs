using System;

public class Product
{
    private string _name;
    private string _product_id;
    private float _price;
    private int _quantity;

    public Product(string name, string product_id, float price, int quantity)
    {
        _name = name;
        _product_id = product_id;
        _price = price;
        _quantity = quantity;
    }

    public float get_TotalCost()
    {
        return _price * _quantity;
    }

    public string get_name()
    {
        return _name;
    }

    public string get_fullProduct()
    {
        return $"{_name} ({_product_id}) - ${_price}, {_quantity}";
    }
}