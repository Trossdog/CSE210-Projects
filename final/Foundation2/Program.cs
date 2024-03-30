using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "Othertown", "NY", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Laptop", "LP123", 1000, 2);
        Product product2 = new Product("Mouse", "MS456", 20, 3);

        List<Product> products1 = new List<Product> {product1, product2};
        List<Product> products2 = new List<Product> {product2};

        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");

    }
}