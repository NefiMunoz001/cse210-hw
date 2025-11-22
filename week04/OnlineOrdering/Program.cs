using System;

class Program
{
    static void Main(string[] args)
    {
        // --- FIRST ORDER ---
        Address addr1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("Homer Simpson", addr1);

        Order order1 = new Order(cust1);

        order1.AddProduct(new Product("Duff Beer 12-pack", "D123", 8.99, 2));
        order1.AddProduct(new Product("Donut Box", "D777", 4.50, 3));

        Console.WriteLine("ORDER 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
        Console.WriteLine("\n---------------------------\n");

        // --- SECOND ORDER ---
        Address addr2 = new Address("Calle 50", "Panamá", "Panamá", "Panama");
        Customer cust2 = new Customer("Steven Sauvestre", addr2);

        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("Laptop Lenovo", "L555", 650.00, 1));
        order2.AddProduct(new Product("Mouse Logitech", "M222", 25.00, 2));

        Console.WriteLine("ORDER 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}

