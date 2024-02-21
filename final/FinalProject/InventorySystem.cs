using System.Collections.Generic;

class InventorySystem
{
    private List<InventoryItem> inventory;

    public InventorySystem()
    {
        inventory = new List<InventoryItem>();
    }

    // Add an item to the inventory
    public void AddItem(InventoryItem item)
    {
        inventory.Add(item);
    }

    // Remove an item from the inventory
    public void RemoveItem(InventoryItem item)
    {
        inventory.Remove(item);
    }

    // To check if an item is available in inventory
    public bool CheckAvailability(InventoryItem item)
    {
        return inventory.Contains(item);
    }

    // Method to find an item by name in the inventory
    public InventoryItem FindItemByName(string name)
    {
        return inventory.FirstOrDefault(item => item.Name.Equals(name));
    }

    // Method to retrieve the inventory items
    public List<InventoryItem> GetInventory()
    {
        return inventory;
    }
}
