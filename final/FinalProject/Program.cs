//This my program is an Inventory Management System. It allows users to perform 
//various operations related to managing inventory and orders.

using System;
using System.Collections.Generic;

class Program
{
    static InventoryManager inventoryManager = new InventoryManager();
    static Order currentOrder = new Order();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Welcome to the Inventory Management System");
            Console.WriteLine("1. Add item to inventory");
            Console.WriteLine("2. Create order");
            Console.WriteLine("3. Calculate total order value");
            Console.WriteLine("4. Check availability of an item");
            Console.WriteLine("5. Remove item from inventory");
            Console.WriteLine("6. View inventory");
            Console.WriteLine("7. View order");
            Console.WriteLine("8. Exit");
            Console.Write("Please enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddItemToInventory();
                    break;
                case "2":
                    CreateOrder();
                    break;
                case "3":
                    CalculateTotalOrderValue();
                    break;
                case "4":
                    CheckAvailability();
                    break;
                case "5":
                    RemoveItemFromInventory();
                    break;
                case "6":
                    ViewInventory();
                    break;
                case "7":
                    ViewOrder();
                    break;
                case "8":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddItemToInventory()
    {
        Console.WriteLine("Adding item to inventory");
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();
        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        Console.Write("Enter price ($): ");
        double price = double.Parse(Console.ReadLine());

        Product product = new Product { Name = name, Quantity = quantity, Price = price };
        inventoryManager.AddItemToInventory(product);

        Console.WriteLine($"Added {product.Name} to inventory.");
    }

    static void CreateOrder()
    {
        Console.WriteLine("Creating order");
        currentOrder = new Order(); // Initialize currentOrder
        bool addMoreItems = true;
        while (addMoreItems)
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            // Search for the product in inventory
            InventoryItem item = inventoryManager.FindItemByName(name);
            if (item != null)
            {
                if (currentOrder.Items == null)
                {
                    currentOrder.Items = new List<OrderItem>(); 
                }
                currentOrder.Items.Add(new OrderItem { Item = item, Quantity = quantity });
                Console.WriteLine($"Added {quantity} {name} to the order.");
            }
            else
            {
                Console.WriteLine($"Product {name} not found in inventory.");
            }

            Console.Write("Add more items to the order? (yes/no): ");
            string response = Console.ReadLine();
            addMoreItems = response.Equals("yes", StringComparison.OrdinalIgnoreCase);
        }
    }

    static void CalculateTotalOrderValue()
    {
        double total = currentOrder.CalculateOrderTotal();
        Console.WriteLine($"Total order value: ${total}");
    }

    static void CheckAvailability()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();
        InventoryItem item = inventoryManager.FindItemByName(name);
        if (item != null)
        {
            bool available = inventoryManager.CheckAvailability(item);
            Console.WriteLine($"Product {name} is {(available ? "available" : "not available")} in inventory.");
        }
        else
        {
            Console.WriteLine($"Product {name} not found in inventory.");
        }
    }

    static void RemoveItemFromInventory()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();
        InventoryItem item = inventoryManager.FindItemByName(name);
        if (item != null)
        {
            inventoryManager.RemoveItemFromInventory(item);
            Console.WriteLine($"Removed {name} from inventory.");
        }
        else
        {
            Console.WriteLine($"Product {name} not found in inventory.");
        }
    }

    static void ViewInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in inventoryManager.GetInventory())
        {
            Console.WriteLine($"Name: {item.Name}, Quantity: {item.Quantity}, Price: {item.Price}");
        }
    }

    static void ViewOrder()
    {
        Console.WriteLine("Order Details:");
        Console.WriteLine($"Customer: {currentOrder.CustomerName}");
        Console.WriteLine($"Order Date: {currentOrder.OrderDate}");

        Console.WriteLine("Items:");
        foreach (var orderItem in currentOrder.Items)
        {
            Console.WriteLine($"Product: {orderItem.Item.Name}, Quantity: {orderItem.Quantity}, Subtotal: ${orderItem.Subtotal}");
        }

        Console.WriteLine($"Total Order Value: ${currentOrder.CalculateOrderTotal()}");
    }
}
