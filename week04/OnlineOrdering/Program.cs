using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // --------------------------------------------------
        // ORDER 1 (USA Customer)
        // --------------------------------------------------
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "P101", 19.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P102", 79.99, 1));

        // Display Order 1 Details
        Console.WriteLine("==================================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");
        Console.WriteLine("==================================================\n");

        // --------------------------------------------------
        // ORDER 2 (International Customer)
        // --------------------------------------------------
        Address address2 = new Address("456 Queen St W", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("HD Monitor 27\"", "P201", 199.99, 1));
        order2.AddProduct(new Product("HDMI Cable 6ft", "P202", 9.99, 3));
        order2.AddProduct(new Product("Desk Mat", "P203", 14.99, 1));

        // Display Order 2 Details
        Console.WriteLine("==================================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
        Console.WriteLine("==================================================");


    }
}