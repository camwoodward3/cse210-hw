using System;

class Program
{

    static void Main(string[] args)
    {
        Product product1 = new Product("Wii", "RVL-003", 250, 1);
        Product product2 = new Product("Wii U", "WUP-001", 300, 1);
        Product product3 = new Product("Switch", "HAC-001", 300, 1);
        Product product4 = new Product("Switch 2", "BEE-001", 450, 1);
        


        Address address1 = new Address("8423 Hollow Drive", "Aurora", "CO", "United States");
        Address address2 = new Address("17 Maple Crescent", "London", "England", "United Kingdom");

        Customer customer1 = new Customer("Jessica Thornton", address1);
        Customer customer2 = new Customer("Oliver Bennett", address2);

        List<Product> orderProducts1 = new List<Product> { product1, product2  };
        List<Product> orderProduct2 = new List<Product> { product3, product4 };


        Order order1 = new Order(orderProducts1, customer1);
        Order order2 = new Order(orderProduct2, customer2);

        Console.WriteLine("===Order 1===");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{order1.CreateShippingLabel()}");

        Console.WriteLine("Packing Label:");
        order1.CreatePackingLabel();

        Console.WriteLine("Total Price:");
        Console.WriteLine($"${order1.get_TotalPrice()}");

        Console.WriteLine();
        Console.WriteLine("===Order 2===");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{order2.CreateShippingLabel()}");

        Console.WriteLine("Packing Label:");
        order2.CreatePackingLabel();

        Console.WriteLine("Total Price:");
        Console.WriteLine($"${order2.get_TotalPrice()}");





    }
}