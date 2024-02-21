// Order.cs
using System;
using System.Collections.Generic;

// Class representing an order
class Order
{
    public string CustomerName { get; set; }
    public List<OrderItem> Items { get; set; }
    public DateTime OrderDate { get; set; }

    public double CalculateOrderTotal()
    {
        double total = 0;
        foreach (var item in Items)
        {
            total += item.Subtotal;
        }
        return total;
    }
}
