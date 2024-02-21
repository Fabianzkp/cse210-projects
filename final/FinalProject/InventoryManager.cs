using System.Collections.Generic;

class InventoryManager
{
    private InventorySystem inventorySystem;

    public InventoryManager()
    {
        inventorySystem = new InventorySystem();
    }

    public void AddItemToInventory(InventoryItem item)
    {
        inventorySystem.AddItem(item);
        Console.WriteLine($"Added {item.Name} to inventory.");
    }

    public void RemoveItemFromInventory(InventoryItem item)
    {
        inventorySystem.RemoveItem(item);
        Console.WriteLine($"Removed {item.Name} from inventory.");
    }

    public bool CheckAvailability(InventoryItem item)
    {
        return inventorySystem.CheckAvailability(item);
    }

    public InventoryItem FindItemByName(string name)
    {
        return inventorySystem.FindItemByName(name);
    }

    // Method to retrieve the inventory items
    public List<InventoryItem> GetInventory()
    {
        return inventorySystem.GetInventory();
    }
}
