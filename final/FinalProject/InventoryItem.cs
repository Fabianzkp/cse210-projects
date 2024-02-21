// InventoryItem.cs
using System;

// Abstract class representing an inventory item
abstract class InventoryItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    // Abstract method to calculate total value
    public abstract double CalculateTotalValue();
}
