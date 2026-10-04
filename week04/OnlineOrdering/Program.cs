using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address address1 = new Address("49 Main Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("Joseph Smith", address1);
        Product product1 = new Product("Soap", "P0001", 200, 2);
        Product product2 = new Product("Milk", "P0002", 350, 4);
        Product product3 = new Product("Sugar", "P0003", 300, 3);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("182 Ingende Ngiri Ngiri", "Kinshasa", "Kinshasa", "DRC");
        Customer customer2 = new Customer("Thethe Ciowa", address2);
        Order order2 = new Order(customer2);
        Product product4 = new Product("Rice", "P0004", 600, 4);
        Product product5 = new Product("Vegetable oil", "P0005", 500, 6);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("ORDER 1");
        Console.WriteLine();
        Console.WriteLine("Packing Label");
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label");
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: {order1.GetTotalPrice()}");
        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine();
        Console.WriteLine("Packing Label");
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label");
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: {order2.GetTotalPrice()}");
    }
}