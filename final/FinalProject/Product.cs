
// Concrete class representing a physical product
class Product : InventoryItem
{
    public override double CalculateTotalValue()
    {
        return Quantity * Price;
    }
}
